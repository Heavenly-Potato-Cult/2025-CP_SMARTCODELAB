using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCodeLab.Models
{
    public class FileItem
    {
        public string Name { get; set; }
        public string FullPath { get; set; }
        public ObservableCollection<FileItem> Children { get; set; } = new ObservableCollection<FileItem>();
        public bool IsDirectory { get; set; }

        public FileItem(string path)
        {
            FullPath = path;
            Name = Path.GetFileName(path);
            IsDirectory = Directory.Exists(path);

            // Load children only for directories
            if (IsDirectory)
            {
                try
                {
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        Children.Add(new FileItem(dir));
                    }

                    foreach (var file in Directory.GetFiles(path))
                    {
                        if (file.EndsWith(".task"))
                            Children.Add(new FileItem(file));
                    }
                }
                catch { /* Handle access denied or other issues gracefully */ }
            }
        }

        // Convert this FileItem and its children to TreeNode
        public TreeNode ToTreeNode()
        {
            TreeNode node = new TreeNode(Name);
            node.Tag = this; // Store the FileItem reference
            node.ImageKey = IsDirectory ? "folder" : "file";
            node.SelectedImageKey = IsDirectory ? "folder" : "file";

            // Recursively add children as TreeNodes
            foreach (var child in Children)
            {
                node.Nodes.Add(child.ToTreeNode());
            }

            return node;
        }

        // Alternative: Convert to TreeNode with lazy loading (better for large directories)
        public TreeNode ToTreeNodeWithLazyLoading()
        {
            TreeNode node = new TreeNode(Name);
            node.Tag = this;
            node.ImageKey = IsDirectory ? "folder" : "file";
            node.SelectedImageKey = IsDirectory ? "folder" : "file";

            // Add a dummy node for directories to enable expansion
            if (IsDirectory && Children.Count > 0)
            {
                node.Nodes.Add(new TreeNode("Loading..."));
            }

            return node;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
