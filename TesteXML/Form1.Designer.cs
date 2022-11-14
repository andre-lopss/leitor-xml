namespace TesteXML
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numeroNfe = new System.Windows.Forms.Label();
            this.lblNfNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaturezaOperacao = new System.Windows.Forms.Label();
            this.lblNfData = new System.Windows.Forms.Label();
            this.lblNfValorTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.descricao = new System.Windows.Forms.ColumnHeader();
            this.qtde = new System.Windows.Forms.ColumnHeader();
            this.unitario = new System.Windows.Forms.ColumnHeader();
            this.valor = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // numeroNfe
            // 
            this.numeroNfe.BackColor = System.Drawing.Color.Transparent;
            this.numeroNfe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numeroNfe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.numeroNfe.Location = new System.Drawing.Point(119, 182);
            this.numeroNfe.Name = "numeroNfe";
            this.numeroNfe.Size = new System.Drawing.Size(107, 25);
            this.numeroNfe.TabIndex = 0;
            this.numeroNfe.Text = "N° da NFe:";
            // 
            // lblNfNum
            // 
            this.lblNfNum.BackColor = System.Drawing.Color.White;
            this.lblNfNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNfNum.Location = new System.Drawing.Point(232, 184);
            this.lblNfNum.Name = "lblNfNum";
            this.lblNfNum.Size = new System.Drawing.Size(223, 25);
            this.lblNfNum.TabIndex = 1;
            this.lblNfNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(119, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Natureza da operação:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(472, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data da emissão:";
            // 
            // lblNaturezaOperacao
            // 
            this.lblNaturezaOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNaturezaOperacao.Location = new System.Drawing.Point(324, 224);
            this.lblNaturezaOperacao.Name = "lblNaturezaOperacao";
            this.lblNaturezaOperacao.Size = new System.Drawing.Size(561, 25);
            this.lblNaturezaOperacao.TabIndex = 4;
            this.lblNaturezaOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNfData
            // 
            this.lblNfData.BackColor = System.Drawing.Color.White;
            this.lblNfData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNfData.Location = new System.Drawing.Point(630, 184);
            this.lblNfData.Name = "lblNfData";
            this.lblNfData.Size = new System.Drawing.Size(255, 25);
            this.lblNfData.TabIndex = 5;
            this.lblNfData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNfValorTotal
            // 
            this.lblNfValorTotal.BackColor = System.Drawing.Color.White;
            this.lblNfValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNfValorTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNfValorTotal.ForeColor = System.Drawing.Color.Black;
            this.lblNfValorTotal.Location = new System.Drawing.Point(360, 598);
            this.lblNfValorTotal.Name = "lblNfValorTotal";
            this.lblNfValorTotal.Size = new System.Drawing.Size(177, 44);
            this.lblNfValorTotal.TabIndex = 7;
            this.lblNfValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(119, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor total da NFe:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(684, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "ABRIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item,
            this.id,
            this.descricao,
            this.qtde,
            this.unitario,
            this.valor});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(119, 274);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(766, 307);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // item
            // 
            this.item.Text = "ITEM";
            this.item.Width = 80;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descricao
            // 
            this.descricao.Text = "DESCRIÇÃO DO PRODUTO";
            this.descricao.Width = 270;
            // 
            // qtde
            // 
            this.qtde.Text = "QUANTIDADE";
            this.qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.qtde.Width = 120;
            // 
            // unitario
            // 
            this.unitario.Text = "UNITÁRIO";
            this.unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.unitario.Width = 110;
            // 
            // valor
            // 
            this.valor.Text = "VALOR";
            this.valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 721);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNfValorTotal);
            this.Controls.Add(this.lblNfData);
            this.Controls.Add(this.lblNaturezaOperacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNfNum);
            this.Controls.Add(this.numeroNfe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label numeroNfe;
        private Label lblNfNum;
        private Label label1;
        private Label label2;
        private Label lblNaturezaOperacao;
        private Label lblNfData;
        private Label lblNfValorTotal;
        private Label label3;
        private Button button1;
        private ListView listView1;
        private ColumnHeader item;
        private ColumnHeader id;
        private ColumnHeader descricao;
        private ColumnHeader qtde;
        private ColumnHeader unitario;
        private ColumnHeader valor;
    }
}