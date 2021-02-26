using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeViewUpdate.Entities;
using TreeViewUpdate.Services;

namespace TreeViewUpdate
{
    public partial class MainForm : Form
    {
        public EFContext _context { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this._context = new EFContext();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DbSeeder.SeedAll(this._context);

            FillTreeView();
        }

        private void FillTreeView() 
        {
            this.tvCategories.Nodes.Clear();
            var coll = this._context.Categories.Select(x => new TreeNode
            {
                Name = x.Id.ToString(),
                Text = x.Name,
                Tag = x
            }).ToList();

            var elements = coll.BuildTree();

            foreach (var el in elements)
            {
                this.tvCategories.Nodes.Add(el);
            }
        }

        private void tvCategories_DoubleClick(object sender, EventArgs e)
        {
            var coll = this._context.Categories
                .Select(x => new TreeNode
                {
                    Name = x.Id.ToString(),
                    Text = x.Name,
                    Tag = x
                }).ToList();
            EditNodeForm form = new EditNodeForm(_context, this.tvCategories.SelectedNode, coll);
            if (form.ShowDialog() == DialogResult.OK) 
            {
                FillTreeView();
            }
        }
    }
}
