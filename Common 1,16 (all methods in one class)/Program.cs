﻿using Common_1_16__all_methods_in_one_class_;

//1/16/1

int aa = EnterToClass.ReadFromConsole();
int bb = EnterToClass.ReadFromConsole();
int cc = EnterToClass.ReadFromConsole();
int result = EnterToClass.MinusAndDivision(aa, bb, cc);
EnterToClass.WriteResult(result);

//1/16/2

int number = EnterToClass.PlusOrMultiplicationOrMinus(0, -5);
Console.WriteLine(number);

//1/16/3

string a = EnterToClass.ConvertingTwodigitNumberToString(55);
Console.WriteLine(a);

//4

bool b = EnterToClass.NumberInRangeFrom0To10OrFrom20To30OFrom40To50(11);
Console.WriteLine(b);

//5

int sum = EnterToClass.SumOfTheNumbersInsideAAndBThatAreDivisibleBySeven(5, 15);
Console.WriteLine(sum);

//6

int c = EnterToClass.ReturnsNumberFromFibonacciSeries(20);
Console.WriteLine(c);

//7

int count = EnterToClass.CountOddDigitsAreTheNumbers(-978512);
Console.WriteLine(count);

//8

int mirrow = EnterToClass.MirroringEnteredNumber(-1021);
Console.WriteLine(mirrow);

//9

bool ident = EnterToClass.IdenticalDigitsInTwoNumbers(01254, 8707);
Console.WriteLine(ident);