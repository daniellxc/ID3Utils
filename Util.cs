using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ID3Utils
{
    public class Util
    {
        public static void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensagemAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static string TratarNomeArquivo(string nomeArquivo)
        {
            if (nomeArquivo.Contains(@"\"))
                nomeArquivo = nomeArquivo.Replace(@"\", "");
            if (nomeArquivo.Contains("/"))
                nomeArquivo = nomeArquivo.Replace("/", "");
            if (nomeArquivo.Contains(":"))
                nomeArquivo = nomeArquivo.Replace(":", "");
            if (nomeArquivo.Contains("*"))
                nomeArquivo = nomeArquivo.Replace("*", "");
            if (nomeArquivo.Contains("?"))
                nomeArquivo = nomeArquivo.Replace("?", "");
            if (nomeArquivo.Contains("<"))
                nomeArquivo = nomeArquivo.Replace("<", "");
            if (nomeArquivo.Contains(">"))
                nomeArquivo = nomeArquivo.Replace(">", "");
            if (nomeArquivo.Contains("|"))
                nomeArquivo = nomeArquivo.Replace("|", "");

            return nomeArquivo;


        }
    }
}
