using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EasyHook.Calls;
using Discord.Webhook;
using Discord;


namespace EasyHook
{
    public partial class MainHook : Form
    {
        public MainHook()
        {
            InitializeComponent();
        }
        private void pstbtn_Click(object sender, EventArgs e)
        {
            pstbtn.Checked = false;
            DiscordWebhookClient client = new DiscordWebhookClient(webhookurl.Text);
            EmbedBuilder embed = new EmbedBuilder();
            embed.WithAuthor(author.Text, authoricon.Text, authorurl.Text);
            embed.WithTitle(title.Text);
            embed.WithUrl(titleurl.Text);
            embed.WithDescription(desc.Text);
            embed.WithFooter(Footer.Text, FooterIconUrl.Text);
            embed.WithThumbnailUrl(thurl.Text);
            embed.WithCurrentTimestamp();
            Embed[] embed1 = { embed.Build() };
            if (webhookname == null && webhookicon == null)
            {
                client.SendMessageAsync(messagecontent.Text, false, embed1); 
            }
            else
            {
                client.SendMessageAsync(desc.Text, false, embed1, username: webhookname, avatarUrl: webhookicon);
            }

        }

        private void profilesettings_Click(object sender, EventArgs e)
        {
            Form profile = new ProfileManage();
            profilesettings.Checked = false;
            this.Hide();
            profile.Show();
        }

        private void MainHook_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
