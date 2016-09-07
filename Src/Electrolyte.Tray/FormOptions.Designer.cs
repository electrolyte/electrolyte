namespace Electrolyte.Tray
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Mouse Jiggler");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Host Editor");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Modules", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.TreeView_Options = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(93, 380);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 1;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // optionPanel
            // 
            this.optionPanel.Location = new System.Drawing.Point(174, 12);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(600, 400);
            this.optionPanel.TabIndex = 2;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(12, 380);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 3;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // TreeView_Options
            // 
            this.TreeView_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreeView_Options.HotTracking = true;
            this.TreeView_Options.Location = new System.Drawing.Point(12, 12);
            this.TreeView_Options.Name = "TreeView_Options";
            treeNode1.Name = "Node0";
            treeNode1.Text = "General";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Mouse Jiggler";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Host Editor";
            treeNode4.Name = "Node1";
            treeNode4.Text = "Modules";
            this.TreeView_Options.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.TreeView_Options.Size = new System.Drawing.Size(156, 350);
            this.TreeView_Options.TabIndex = 4;
            this.TreeView_Options.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView_Options_AfterSelect);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 422);
            this.Controls.Add(this.TreeView_Options);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.ButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "Options";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.TreeView TreeView_Options;
    }
}