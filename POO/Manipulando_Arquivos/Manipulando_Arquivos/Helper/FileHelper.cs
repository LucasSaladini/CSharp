using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manipulando_Arquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string path)
        {
            var retornoCaminho = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivos(string path)
        {
            var retornoArquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorio(string path)
        {
            var retorno = Directory.CreateDirectory(path);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string path, bool apagarArquivos)
        {
            Directory.Delete(path, apagarArquivos);
        }

        public void CriarArquivoTexto(string path, string conteudo)
        {
            if(!File.Exists(path))
            {
                File.WriteAllText(path, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string path, List<string> conteudo)
        {
            if(!File.Exists(path))
            {
                using (var stream = File.CreateText(path))
                {
                    foreach (var linha in conteudo)
                    {
                        stream.WriteLine(linha);
                    }
                }
            }
        }

        public void AdicionarTexto(string path, string conteudo)
        {
            File.AppendAllText(path, conteudo);
        }

        public void AdicionarTextoStream(string path, List<string> conteudo)
        {
         
            using (var stream = File.AppendText(path))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivo(string path)
        {
            var conteudo = File.ReadAllLines(path);

            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string path)
        {
            string linha = string.Empty;

            using (var stream = File.OpenText(path))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string path, string newPath, bool sobrescrever)
        {
            File.Move(path, newPath, sobrescrever);
        }

        public void CopiarArquivo(string path, string newPath, bool sobrescrever)
        {
            File.Copy(path, newPath, sobrescrever);
        }

        public void ApagarArquivo(string path)
        {
            File.Delete(path);
        }
    }
}