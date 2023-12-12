namespace accounting_project
{
    partial class accounting_tree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("الأصول");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("الإلتزامات");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("المصروفات");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("الإيرادات");
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label12 = new System.Windows.Forms.Label();
            this.txtprice_s = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_s = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_s = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label11 = new System.Windows.Forms.Label();
            this.txtprice_r = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_r = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.txtprice_m = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_m = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_m = new System.Windows.Forms.TextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice_e = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_e = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 1;
            this.ribbon.Name = "ribbon";
            this.ribbon.Size = new System.Drawing.Size(460, 49);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 529);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(460, 31);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Controls.Add(this.txtprice_s);
            this.groupControl2.Controls.Add(this.button2);
            this.groupControl2.Controls.Add(this.button1);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.cmb_s);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.txt_s);
            this.groupControl2.Location = new System.Drawing.Point(181, 55);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl2.Size = new System.Drawing.Size(267, 118);
            this.groupControl2.TabIndex = 11;
            this.groupControl2.Text = "التعامل مع بنود الأصول";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "السعر";
            // 
            // txtprice_s
            // 
            this.txtprice_s.Location = new System.Drawing.Point(77, 83);
            this.txtprice_s.Name = "txtprice_s";
            this.txtprice_s.Size = new System.Drawing.Size(139, 20);
            this.txtprice_s.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(5, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "حذف";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(5, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(215, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "إسم البند";
            // 
            // cmb_s
            // 
            this.cmb_s.FormattingEnabled = true;
            this.cmb_s.Location = new System.Drawing.Point(75, 23);
            this.cmb_s.Name = "cmb_s";
            this.cmb_s.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_s.Size = new System.Drawing.Size(137, 21);
            this.cmb_s.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "إسم البند";
            // 
            // txt_s
            // 
            this.txt_s.Location = new System.Drawing.Point(75, 54);
            this.txt_s.Name = "txt_s";
            this.txt_s.Size = new System.Drawing.Size(139, 20);
            this.txt_s.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.txtprice_r);
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.button4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cmb_r);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_r);
            this.groupControl1.Location = new System.Drawing.Point(181, 179);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(267, 111);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "التعامل مع بنود الإلتزامات";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "السعر";
            // 
            // txtprice_r
            // 
            this.txtprice_r.Location = new System.Drawing.Point(77, 82);
            this.txtprice_r.Name = "txtprice_r";
            this.txtprice_r.Size = new System.Drawing.Size(139, 20);
            this.txtprice_r.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(5, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(5, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "إضافة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "إسم البند";
            // 
            // cmb_r
            // 
            this.cmb_r.FormattingEnabled = true;
            this.cmb_r.Location = new System.Drawing.Point(75, 23);
            this.cmb_r.Name = "cmb_r";
            this.cmb_r.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_r.Size = new System.Drawing.Size(137, 21);
            this.cmb_r.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "إسم البند";
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(75, 54);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(139, 20);
            this.txt_r.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.label9);
            this.groupControl3.Controls.Add(this.txtprice_m);
            this.groupControl3.Controls.Add(this.button5);
            this.groupControl3.Controls.Add(this.button6);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.cmb_m);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.txt_m);
            this.groupControl3.Location = new System.Drawing.Point(181, 296);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl3.Size = new System.Drawing.Size(267, 114);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "التعامل مع بنود المصاريف";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "السعر";
            // 
            // txtprice_m
            // 
            this.txtprice_m.Location = new System.Drawing.Point(74, 84);
            this.txtprice_m.Name = "txtprice_m";
            this.txtprice_m.Size = new System.Drawing.Size(139, 20);
            this.txtprice_m.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button5.Location = new System.Drawing.Point(5, 77);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "حذف";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button6.Location = new System.Drawing.Point(5, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 27);
            this.button6.TabIndex = 6;
            this.button6.Text = "إضافة";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "إسم البند";
            // 
            // cmb_m
            // 
            this.cmb_m.FormattingEnabled = true;
            this.cmb_m.Location = new System.Drawing.Point(75, 23);
            this.cmb_m.Name = "cmb_m";
            this.cmb_m.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_m.Size = new System.Drawing.Size(137, 21);
            this.cmb_m.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "إسم البند";
            // 
            // txt_m
            // 
            this.txt_m.Location = new System.Drawing.Point(75, 54);
            this.txt_m.Name = "txt_m";
            this.txt_m.Size = new System.Drawing.Size(139, 20);
            this.txt_m.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.label8);
            this.groupControl4.Controls.Add(this.txtprice_e);
            this.groupControl4.Controls.Add(this.button7);
            this.groupControl4.Controls.Add(this.button8);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.cmb_e);
            this.groupControl4.Controls.Add(this.label7);
            this.groupControl4.Controls.Add(this.txt_e);
            this.groupControl4.Location = new System.Drawing.Point(181, 416);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl4.Size = new System.Drawing.Size(267, 107);
            this.groupControl4.TabIndex = 14;
            this.groupControl4.Text = "التعامل مع بنود الإيرادات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "السعر";
            // 
            // txtprice_e
            // 
            this.txtprice_e.Location = new System.Drawing.Point(77, 82);
            this.txtprice_e.Name = "txtprice_e";
            this.txtprice_e.Size = new System.Drawing.Size(139, 20);
            this.txtprice_e.TabIndex = 8;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button7.Location = new System.Drawing.Point(5, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "حذف";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button8.Location = new System.Drawing.Point(5, 23);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(64, 27);
            this.button8.TabIndex = 6;
            this.button8.Text = "إضافة";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "إسم البند";
            // 
            // cmb_e
            // 
            this.cmb_e.FormattingEnabled = true;
            this.cmb_e.Location = new System.Drawing.Point(75, 23);
            this.cmb_e.Name = "cmb_e";
            this.cmb_e.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_e.Size = new System.Drawing.Size(137, 21);
            this.cmb_e.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "إسم البند";
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(75, 54);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(139, 20);
            this.txt_e.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button9.Location = new System.Drawing.Point(9, 483);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(163, 35);
            this.button9.TabIndex = 15;
            this.button9.Text = "رجـــــــــــــــــوع";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 55);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "الأصول";
            treeNode2.Name = "Node1";
            treeNode2.Text = "الإلتزامات";
            treeNode3.Name = "Node2";
            treeNode3.Text = "المصروفات";
            treeNode4.Name = "Node3";
            treeNode4.Text = "الإيرادات";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(163, 422);
            this.treeView1.TabIndex = 16;
            // 
            // accounting_tree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 560);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "accounting_tree";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "بيانات شجرة الحسابات";
            this.Load += new System.EventHandler(this.accounting_tree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_s;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_r;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_r;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_m;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_e;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtprice_m;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtprice_e;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtprice_s;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtprice_r;
    }
}