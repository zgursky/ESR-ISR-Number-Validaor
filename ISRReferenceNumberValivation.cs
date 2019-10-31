public static bool ISRReferenceNumberValivation(string number)
{
  int[] arrTable = { 0, 9, 4, 6, 8, 2, 7, 1, 3, 5 };
  var carry = 0;
  var controlDigit = number.Substring(number.Length - 1, 1);
  number = number.Remove(number.Length - 1);
  var i = 1;  
  for (i = 0; i <= number.Length - 1; i++)
  {
    carry = arrTable[(carry + Convert.ToInt32(number.Substring(i, 1))) % 10];
  }
  
  var calculatedContolDigit = ((10 - carry) % 10).ToString();
  var result = calculatedContolDigit == controlDigit;
  return result;
}
