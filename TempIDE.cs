using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Media;



//For WPF ;>
using WpfTreeView = System.Windows.Controls.TreeView;
using WpfTreeViewItem = System.Windows.Controls.TreeViewItem;
using WpfColor = System.Windows.Media.Color;
using WpfBrushes = System.Windows.Media.Brushes;
using WpfSolidColorBrush = System.Windows.Media.SolidColorBrush;
using WpfSystemColors = System.Windows.SystemColors;
using EH = System.Windows.Forms.Integration.ElementHost;

namespace SmartCodeLab
{
    public partial class TempIDE : Form
    {



        private bool isResizingTabs = false;
        private System.Windows.Controls.TreeView wpfTree;
        public TempIDE()
        {
            InitializeComponent();
            InitializeWPFTree();
            setTabControl();
        }
        private void setTabControl()
        {
            tabControl2.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl2.DrawItem += tabcontrol_DrawItem;
            tabControl2.MouseDown += tabControl2_MouseDown;
        }

        private void tabcontrol_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = tabControl2.TabPages[e.Index];
            var tabRect = tabControl2.GetTabRect(e.Index);

            // Draw tab text
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabControl2.Font, tabRect, tabPage.ForeColor);

            // Draw "X" on the right
            var closeRect = new Rectangle(tabRect.Right - 15, tabRect.Top + 2, 12, 12);
            e.Graphics.DrawString("x", tabControl1.Font, System.Drawing.Brushes.Red, closeRect.Location);
        }
        private void tabControl2_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tabControl2.TabPages.Count; i++)
            {
                var tabRect = tabControl2.GetTabRect(i);
                var closeRect = new Rectangle(tabRect.Right - 15, tabRect.Top + 2, 12, 12);
                if (closeRect.Contains(e.Location))
                {
                    tabControl2.TabPages.RemoveAt(i);
                    break;
                }
            }
        }


        private void ResizeTabs()
        {
            if (isResizingTabs) { return; } // Prevent recursion

            if (tabControl_RightSide.TabPages.Count == 0) { return; }

            int totalWidth = tabControl_RightSide.ClientSize.Width;
            if (totalWidth <= 0) { return; }



            isResizingTabs = true;


            try
            {
                int tabCount = tabControl_RightSide.TabPages.Count;
                int tabWidth = (totalWidth / tabCount) - 2;

                tabControl_RightSide.Font = new Font("Segoe UI", 12F);
                tabControl_RightSide.SizeMode = TabSizeMode.Fixed;
                tabControl_RightSide.ItemSize = new Size(tabWidth, 50); // 50 = tab height
            }
            finally
            {
                isResizingTabs = false;
            }
        }

        private void tabControl_RightSide_Resize(object sender, EventArgs e)
        {
            ResizeTabs();
        }

        private void TempIDE_Shown(object sender, EventArgs e)
        {
            ResizeTabs();
            tabControl_RightSide.Invalidate();
        }

        private void InitializeWPFTree()
        {
            if (panel_LeftSide_Directory == null) return;

            wpfTree = new WpfTreeView
            {
                Background = WpfBrushes.White,
                Foreground = WpfBrushes.Black,
                FontSize = 14
            };

            wpfTree.Resources[WpfSystemColors.HighlightBrushKey] = new WpfSolidColorBrush(WpfColor.FromRgb(200, 230, 255));
            wpfTree.Resources[WpfSystemColors.ControlBrushKey] = new WpfSolidColorBrush(WpfColor.FromRgb(220, 240, 255));


            var host = new EH
            {
                Dock = DockStyle.Fill,
                Child = wpfTree
            };

            panel_LeftSide_Directory.Controls.Add(host);
        }

        private void LoadFolder(string path, WpfTreeViewItem parent)
        {
            try
            {
                // Add subfolders
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var folderNode = new WpfTreeViewItem { Header = Path.GetFileName(dir) };
                    parent.Items.Add(folderNode);
                    LoadFolder(dir, folderNode);
                }

                // Add files
                foreach (var file in Directory.GetFiles(path))
                {
                    parent.Items.Add(new WpfTreeViewItem { Header = Path.GetFileName(file) });
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Skip folders we can't access
            }
        }



        private WpfTreeViewItem CreateFolderNode(string path)
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            if (!Directory.Exists(path)) return null;

            var folderNode = new WpfTreeViewItem { Header = Path.GetFileName(path), Tag = path };
            folderNode.Expanded += FolderNode_Expanded;

            var hasChildren = Directory.GetDirectories(path).Length > 0 || Directory.GetFiles(path).Length > 0;
            if (hasChildren)
                folderNode.Items.Add(null);

            return folderNode;
        }

        private async void FolderNode_Expanded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!(sender is WpfTreeViewItem node)) return;
            if (node.Items.Count != 1) return;
            if (node.Items[0] != null) return;

            node.Items.Clear();

            if (!(node.Tag is string path)) return;
            if (!Directory.Exists(path)) return;

            string[] dirs;
            string[] files;

            try
            {
                dirs = await Task.Run(() => Directory.GetDirectories(path));
                files = await Task.Run(() => Directory.GetFiles(path));
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }



            foreach (var dir in dirs)
            {
                var dirNode = CreateFolderNode(dir);
                if (dirNode != null)
                    node.Items.Add(dirNode);
            }

            foreach (var file in files)
            {
                if (string.IsNullOrWhiteSpace(file)) continue;
                var fileNode = new WpfTreeViewItem { Header = Path.GetFileName(file), Tag = file };
                node.Items.Add(fileNode);
            }
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            if (wpfTree == null) return;

            wpfTree.Items.Clear();

            var rootNode = CreateFolderNode(dialog.SelectedPath);
            if (rootNode == null) return;

            wpfTree.Items.Add(rootNode);
        }

    }
}
