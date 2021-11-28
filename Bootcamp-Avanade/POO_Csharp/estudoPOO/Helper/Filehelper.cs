using System.IO;

namespace estudoPOO.Helper
{
    public class Filehelper
    {
        public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho,"*", SearchOption.AllDirectories );
              
              foreach (var retorno in retornoCaminho)
              {
                  System.Console.WriteLine(retorno);
              }
        }
    }
}