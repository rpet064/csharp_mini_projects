// Solution for https://learn.microsoft.com/en-us/training/modules/csharp-modify-content/4-challenge

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

const string openSpan = "<span>" ;
const string closeSpan = "</span>" ;
const string openDiv = "<div>" ;
const string closeDiv = "</div>" ;

string quantity = "";
string output = "";

int spanOpenIndex = input.IndexOf(openSpan);
int spanCloseIndex = input.IndexOf(closeSpan);
int spanLength = spanCloseIndex - spanOpenIndex - openSpan.Length;

spanOpenIndex += openSpan.Length;
quantity = input.Substring(spanOpenIndex, spanLength);

int divOpenIndex = input.IndexOf(openDiv);
int divCloseIndex = input.IndexOf(closeDiv);
int divLength = divCloseIndex - divOpenIndex - openDiv.Length;

divOpenIndex += openDiv.Length;

output = input.Substring(divOpenIndex, divLength);


Console.Write($"Quantity: {quantity} \n");
Console.Write($"Output: {output}");


