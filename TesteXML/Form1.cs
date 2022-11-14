using System.Xml;

namespace TesteXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LerXmlNfe();
        }

        private void LerXmlNfe()
        {
            var arquivo = @"C:\Users\andre\source\repos\TesteXML\TesteXML\xml\nfe.xml";
            var item = "";
            var cProd = "";
            var xProd = "";
            var qCom = "";
            var vUnCom = "";
            var vProd = "";

            using(XmlReader meuXml = XmlReader.Create(arquivo))
            {
                var fimItens = false;
                while (meuXml.Read())
                {
                    if(meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "natOp")
                        lblNaturezaOperacao.Text = meuXml.ReadElementString();
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "nNF")
                        lblNfNum.Text = meuXml.ReadElementString();
                    if(meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "dhEmi") 
                        lblNfData.Text = meuXml.ReadElementString();

                    //---- itens da nf
                    if(meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "det")
                    {
                        item = meuXml.GetAttribute("nItem");

                        cProd = "";
                        xProd = "";
                        qCom = "";
                        vUnCom = "";
                        vProd = "";
                    }else if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "total")
                    {
                        fimItens = true;
                    }

                    if (!fimItens)
                    {
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "cProd")
                            cProd = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "xProd")
                            xProd = meuXml.ReadElementString();
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "qCom")
                            qCom = meuXml.ReadElementString(); 
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vUnCom")
                            vUnCom = meuXml.ReadElementString();        
                        if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vProd")
                        {
                            vProd = meuXml.ReadElementString().Replace(".", ",");
                            listView1.Items.Add(new ListViewItem(new[] { item, cProd,xProd, qCom, vUnCom.ToString(),
                                vProd.ToString().Replace(".", ",")}));
                        }
                    }

                    //--rodapé
                    if (meuXml.NodeType == XmlNodeType.Element && meuXml.Name == "vNF")
                        lblNfValorTotal.Text = "R$" + meuXml.ReadElementString().Replace(".", ",");
                }
            } 

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}