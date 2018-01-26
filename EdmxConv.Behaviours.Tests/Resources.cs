﻿using System.IO;

namespace EdmxConv.Behaviours.Tests
{
    internal static class Resources
    {
        public static string SampleDatabaseEdmx => @"0x1F8B080000000000000BCC57DB6E1B37107D2FD07F20F8D4028E683B2FADB19BC095ADC06864075927EFD4EE4826CACB861743FAB63EF493FA0B1DEE5DBB9615274551183096DC993333876786ABBFFFFC2B79BB55923C8275C2E8949ECD4E29019D9B42E84D4A835FBFFA85BE7DF3E30FC975A1B6E4736BF73ADAA1A776297DF0BEBC60CCE50FA0B89B29915BE3CCDACF72A3182F0C3B3F3DFD959D9D3140088A5884241F83F64241B5C0E5DCE81C4A1FB85C9A02A46BF6F14D56A1925BAEC0953C8794665C9512AEB8E72BEE60D62C5708E161EB29B99482635619C835255C6BE3B9C79C2F3E39C8BC357A9395B8C1E5FDAE04B45B73E9A0A9E5A237FFDAB24ECF6359AC776CA1F2E0BC512F043C7BDDF0C4C6EEDFC4764D76C3E43532EE77B1EA8ACD942E8CA1641CE7622E6DB439C6F3AC8213E066087342F68D4F3AA1A09EE2DF099907E983855443F096CB13F221ACA4C87F87DDBDF90374AA8394C37431617CB7B7815B1FAC29C1FADD47583745DC1494B07D3F3676ECDC063E758DEF82C0E75B8CCD57123A31B067DDE3FF160015858D42C9926FDF83DEF88794E223250BB185A2DD69503F69817D854EDE86519084F5A7333DB34839171A6C93C044F2934344AD37E7E89A70FB15D5B819F85E0A8E923E87BA7DE2D13E9D679751DFA8ACEED4B6A3D981964E96BC2C91B2418B373B24ABFB7BFE2A7BB9D8558DC172F784E6BB6CBB48DE58BE81D15B0C8D992E8475BE153225F3424DCCC6FC1FE0B68D36A078ACE79EF1D6383EEF9DF2A1FE8B673382EBB95C60790AB4AF2A852EA3BAE7275ED598E592DB27FA646E6450FA50AF3DE75DB7C9D0BFDE9922246C94F698A641773496A38E1F73FE9C64C7265DF44EBA2389268D5C8E5F4D13FDD4269420358FA2A8B4B3731ED42C1ACCB22F722E05D6DB1B2CB9166B70BE1E8A146F84F3D18DF6FFB95D9873853C7EC5FCE7433D68F12500B289D9AC05D8EF1AF0FA91DBFC81DB9F14DFFE3C44FADE213E9D354747F4A1095DAB2CA5C50A17F7757AF544FFC6D93D157CC2865F6CC91538B1E921E2F79B863C2AA9076D6D6EF4DAB4046339C38C5A9311FF4BF0BC40562E2D1E20CF3DBECEC1B9EAA2FDCC6540936BB582E246DF055F067FE91CA895DC0DEB4DD8F3F1AB0B6A3FE7E4AE8C2BF76F9480690A2C01EEF46F41C8A2CB7B31D5DF218828907780FB5587E28706C26DB0C606E9D6E8AF046AE8BB8212746C8A7BC09B04C1DC9DCEF82382BC3C37FCBE780F1B9EEFDAB97518E4F841ECD39E5C09BEB15CB906A3F78FBF4258FC19F2E61F000000FFFF03008574340FB80C0000";


        public static string SampleResourceEdmx => @"H4sIAAAAAAAAC8xX224bNxB9L9B/IPjUAo5oOy+tsZvAla3AaGQHWSfv1O5IJsrLhhdD+rY+9JP6Cx3uXbuWFSdFURgwltyZMzOHZ4arv//8K3m7VZI8gnXC6JSezU4pAZ2bQuhNSoNfv/qFvn3z4w/JdaG25HNr9zraoad2KX3wvrxgzOUPoLibKZFb48zaz3KjGC8MOz89/ZWdnTFACIpYhCQfg/ZCQbXA5dzoHEofuFyaAqRr9vFNVqGSW67AlTyHlGZclRKuuOcr7mDWLFcI4WHrKbmUgmNWGcg1JVxr47nHnC8+Oci8NXqTlbjB5f2uBLRbc+mgqeWiN//ask7PY1msd2yh8uC8US8EPHvd8MTG7t/Edk12w+Q1Mu53seqKzZQujKFkHOdiLm20OcbzrIIT4GYIc0L2jU86oaCe4t8JmQfpg4VUQ/CWyxPyIaykyH+H3b35A3Sqg5TDdDFhfLe3gVsfrCnB+t1HWDdF3BSUsH0/Nnbs3AY+dY3vgsDnW4zNVxI6MbBn3eP/FgAVhY1CyZJv34Pe+IeU4iMlC7GFot1pUD9pgX2FTt6GUZCE9aczPbNIORcabJPARPKTQ0StN+fomnD7FdW4GfheCo6SPoe6feLRPp1nl1HfqKzu1Laj2YGWTpa8LJGyQYs3OySr+3v+Knu52FWNwXL3hOa7bLtI3li+gdFbDI2ZLoR1vhUyJfNCTczG/B/gto02oHis557x1jg+753yof6LZzOC67lcYHkKtK8qhS6juucnXtWY5ZLbJ/pkbmRQ+lCvPeddt8nQv96ZIiRslPaYpkF3NJajjh9z/pxkxyZd9E66I4kmjVyOX00T/dQmlCA1j6KotLNzHtQsGsyyL3IuBdbbGyy5Fmtwvh6KFG+E89GN9v+5XZhzhTx+xfznQz1o8SUAsonZrAXY7xrw+pHb/IHbnxTf/jxE+t4hPp01R0f0oQldqyylxQoX93V69UT/xtk9FXzChl9syRU4sekh4vebhjwqqQdtbW702rQEYznDjFqTEf9L8LxAVi4tHiDPPb7Owbnqov3MZUCTa7WC4kbfBV8Gf+kcqJXcDetN2PPxqwtqP+fkrowr92+UgGkKLAHu9G9ByKLLezHV3yGIKJB3gPtVh+KHBsJtsMYG6dborwRq6LuCEnRsinvAmwTB3J3O+COCvDw3/L54Dxue79q5dRjk+EHs055cCb6xXLkGo/ePv0JY/Bny5h8AAAD//wMAhXQ0D7gMAAA=";

        public static string SampleXmlEdmx { get; } = GetSampleXmlEdmx();
        public static string GetSampleXmlEdmx() // TODO replace with using ext method 
        {
            using (var file = File.OpenText("SampleEdmx.xml"))
                return file.ReadToEnd();
        }
    }
}
