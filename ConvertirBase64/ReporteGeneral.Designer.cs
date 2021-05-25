
namespace ConvertirBase64
{
    partial class ReporteGeneral
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_votosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eleccionDataSet = new ConvertirBase64.eleccionDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_votosTableAdapter = new ConvertirBase64.eleccionDataSetTableAdapters.tb_votosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tb_votosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleccionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_votosBindingSource
            // 
            this.tb_votosBindingSource.DataMember = "tb_votos";
            this.tb_votosBindingSource.DataSource = this.eleccionDataSet;
            // 
            // eleccionDataSet
            // 
            this.eleccionDataSet.DataSetName = "eleccionDataSet";
            this.eleccionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetElecciones";
            reportDataSource1.Value = this.tb_votosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ConvertirBase64.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(845, 417);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_votosTableAdapter
            // 
            this.tb_votosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 455);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.Name = "ReporteGeneral";
            this.Text = "ReporteGeneral";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_votosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eleccionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_votosBindingSource;
        private eleccionDataSet eleccionDataSet;
        private eleccionDataSetTableAdapters.tb_votosTableAdapter tb_votosTableAdapter;
    }
}