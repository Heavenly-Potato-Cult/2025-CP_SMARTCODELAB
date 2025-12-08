using SmartCodeLab.Models;
using System.ComponentModel;
using SmartCodeLab.CustomComponents.SteamThings;

namespace SmartCodeLab.CustomComponents
{
    public partial class UserIcons : UserControl
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public UserProfile profile { get; set; }
        private Action<UserProfile, UserIcons> _onSelectCallback;

        public bool isActive { get; private set; }

        private Color DefaultColor = Color.FromArgb(11, 14, 17);
        private Color OriginaltBackColor;
        private Color SelectedColor = Color.FromArgb(27, 40, 56);
        private Color SelectedIndicator = Color.FromArgb(26, 191, 32);
        public UserIcons(UserProfile profile, Action<UserProfile, UserIcons> setSelectedUserId)
        {
            InitializeComponent();
            this.profile = profile;
            this._onSelectCallback = setSelectedUserId;
            username.Text = profile._studentName;
            OriginaltBackColor = this.BackColor;
            if (!string.IsNullOrEmpty(profile._studentName))
            {
                initialsLetter.Text = profile._studentName.Substring(0, 1).ToUpper();
                initialsPanel.BackColor = GetAvatarColor(profile._studentName);
            }
            else
            {
                initialsLetter.Text = "?";
                initialsPanel.BackColor = Color.FromArgb(50, 50, 50);// Fallback if name is missing
            }

            customCard3.BackColor = DefaultColor;
            indicator.BackColor = DefaultColor;
            status.SteamTheme = SteamLabel.ThemeOption.Muted;


            status.Text = "Inactive";
            isActive = false;
            //customCard3.Click += (s, e) =>
            //{
            //    if (customCard3.BackColor == DefaultColor)
            //    {
            //        //_ = FocusStatus(true);
            //        customCard3.BackColor = SelectedColor;
            //        indicator.BackColor = SelectedIndicator;
            //        setSelectedUserId?.Invoke(this.profile, this);
            //    }
            //};

            customCard3.Click += SelectThisUser;
            username.Click += SelectThisUser;
            initialsLetter.Click += SelectThisUser;
            status.Click += SelectThisUser;
            indicator.Click += SelectThisUser;
        }
        private void SelectThisUser(object sender, EventArgs e)
        {
           
            if (customCard3.BackColor == DefaultColor)
            {
                
                customCard3.BackColor = SelectedColor;
                indicator.BackColor = SelectedIndicator;


                _onSelectCallback?.Invoke(this.profile, this);
                //setSelectedUserId?.Invoke(this.profile, this);

            }
        }

        public void LostFocusDisplay()
        {
            this.Invoke((Action)(() => { customCard3.BackColor = DefaultColor; indicator.BackColor = DefaultColor; }));
        }

        public void HaveUnreadMessages()
        {
            this.Invoke((Action)(() => { this.BackColor = Color.FromArgb(26, 191, 32); }));
        }

        public void ClearUnreadMessages()
        {
            this.Invoke((Action)(() => { this.BackColor = OriginaltBackColor; }));
        }

        public void setNameText(string newName)
        {
            this.Invoke((Action)(() => username.Text = newName));
        }

        public void setStatus(bool isActive)
        {
            this.isActive = isActive;
            this.Invoke((Action)(() =>
            {
                if (isActive)
                {
                    //status.ForeColor = Color.LimeGreen;
                    status.SteamTheme = SteamLabel.ThemeOption.Accent;
                    status.Text = "Active";
                }
                else
                {
                    status.SteamTheme = SteamLabel.ThemeOption.Muted;
                    status.Text = "Inactive";
                }
            }));
        }

        private Color GetAvatarColor(string name)
        {
            if (string.IsNullOrEmpty(name)) return Color.Gray;

            
            Color[] palette = new Color[]
            {
                Color.FromArgb(70, 90, 110),   // Muted Blue
                Color.FromArgb(100, 60, 60),   // Muted Red
                Color.FromArgb(60, 90, 70),    // Muted Green
                Color.FromArgb(100, 80, 120),  // Muted Purple
                Color.FromArgb(110, 90, 60),   // Muted Gold
                Color.FromArgb(60, 80, 90),    // Teal Grey
                Color.FromArgb(140, 70, 70),   // Brick Red
                Color.FromArgb(80, 80, 100)    // Slate
            };

            // Use HashCode so the color is linked to the name forever
            int hash = Math.Abs(name.GetHashCode());
            int index = hash % palette.Length;

            return palette[index];
        }

        private void customCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
