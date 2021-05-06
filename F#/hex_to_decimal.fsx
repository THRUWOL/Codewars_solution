(*
[8 kyu] - Hex to Decimal

Complete the function which converts hex number (given as a string) to a decimal number.
*)

let hexToDec s = System.Convert.ToInt32 (s, 16) |> float
