using System;
using System.Collections.Generic;
using DataLibrary;

namespace DocumentLibrary
{
    public interface IDocument
    {
        void DocumentBuilder(List<Customer> items);
    }
}
