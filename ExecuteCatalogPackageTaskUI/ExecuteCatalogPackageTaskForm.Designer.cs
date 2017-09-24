namespace ExecuteCatalogPackageTaskUI
{
    partial class ExecuteCatalogPackageTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecuteCatalogPackageTaskForm));
            this.lblInstance = new System.Windows.Forms.Label();
            this.txtInstance = new System.Windows.Forms.TextBox();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstance.Location = new System.Drawing.Point(12, 9);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(61, 16);
            this.lblInstance.TabIndex = 0;
            this.lblInstance.Text = "Instance:";
            // 
            // txtInstance
            // 
            this.txtInstance.Location = new System.Drawing.Point(79, 8);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(248, 20);
            this.txtInstance.TabIndex = 1;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(79, 34);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(248, 20);
            this.txtFolder.TabIndex = 3;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder.Location = new System.Drawing.Point(12, 35);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(50, 16);
            this.lblFolder.TabIndex = 2;
            this.lblFolder.Text = "Folder:";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(79, 60);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(248, 20);
            this.txtProject.TabIndex = 5;
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProject.Location = new System.Drawing.Point(12, 61);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(53, 16);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Project:";
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(79, 86);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(248, 20);
            this.txtPackage.TabIndex = 7;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackage.Location = new System.Drawing.Point(12, 87);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(66, 16);
            this.lblPackage.TabIndex = 6;
            this.lblPackage.Text = "Package:";
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(252, 112);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ExecuteCatalogPackageTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 144);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.txtPackage);
            this.Controls.Add(this.lblPackage);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtInstance);
            this.Controls.Add(this.lblInstance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExecuteCatalogPackageTaskForm";
            this.Text = "Execute Catalog Package Task Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstance;
        private System.Windows.Forms.TextBox txtInstance;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.Button btnDone;
    }
}