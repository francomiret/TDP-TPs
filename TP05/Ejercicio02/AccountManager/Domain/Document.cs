using System;

namespace Ejercicio02.AccountManager.Domain
{
    public class Document
    {
        public Document()
        {
        }
        public Document(DocumentType pTipo, string pNumero)
        {
            Type = pTipo;
            Number = pNumero;
        }
        public DocumentType Type { get; set; }

        public String Number { get; set; }

    }
}
