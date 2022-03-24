// See https://aka.ms/new-console-template for more information
using ProntoSecorro;
using ProntoSecorro.factories;
using ProntoSecorro.Guinchos;
using ProntoSecorro.Veiculos;
using System.IO;
using System.Text;

Console.WriteLine("Olá mundo!");
try
{
    IGuinchoVeiculoFactory gvp = new GuinchoVeiculoPequenoFactory();
    IGuinchoVeiculoFactory gvm = new GuinchoVeiculoMedioFactory();
    IGuinchoVeiculoFactory gvg = new GuinchoVeiculoGrandeFactory();

    IGuincho gp = gvp.createGuincho();
    IGuincho gm = gvm.createGuincho();
    IGuincho gg = gvg.createGuincho();

    Veiculo cp = gvp.createVeiculo();
    cp.Modelo = "Celta";

    Veiculo cm = gvm.createVeiculo();
    cm.Modelo = "Jetta";

    Veiculo cg = gvg.createVeiculo();
    cg.Modelo = "BMW X6";

    //Secorrer
   
    

    StreamWriter sw;
    string caminho = "C:\\Users\\rcostame\\Desktop\\ProntoSecorro.log";
    sw = File.AppendText(caminho);
    sw.WriteLine("Pronto Secorro:");
    sw.WriteLine(gp.Secorrer(cp));
    sw.WriteLine(gm.Secorrer(cm));
    sw.WriteLine(gg.Secorrer(cg));
    sw.Close();
}catch(Exception ex)
{
    Console.WriteLine("Erro! "+ex.Message);
}



