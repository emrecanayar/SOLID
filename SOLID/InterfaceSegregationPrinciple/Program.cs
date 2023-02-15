#region Not Ideal Code
using InterfaceSegregationPrinciple;

SamsungPrinter printer = new();
printer.PrintDuplex();
#endregion
#region Ideal Code
InterfaceSegregationPrincipleIdealCode.SamsungPrinter printerIdelCode = new();
printerIdelCode.Fax();
#endregion