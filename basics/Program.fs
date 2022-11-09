// Walkthrough: https://www.youtube.com/watch?v=c7eNDJN758U&t=1649s

open System

// let basics_demo() =
// loopings stuff
//   let rand_list = [1;2;3]
//   let rand_list2 = List.map(fun x -> x * 2) rand_list

//   printfn "Double List: %A" rand_list2

//   [5;6;7;8]
//   |> List.filter (fun v -> v % 2 = 0)
//   |> List.map (fun x -> x * 2)
//   |> printfn "Even Doubles: %A" 

//  func stuff
//   let mult_num x = x * 3
//   let add_num y = y + 5

//   let mult_add = mult_num >> add_num
//   let add_mult = mult_num << add_num

//   printf "mult_add: %i" (mult_add 10)
//   printf "add_mult: %i" (add_mult 10)

  // let number = 2
  // printfn "Type: %A" (number.GetType())
  // printfn "A Float: %A" (float number)
  // printfn "An Int: %A" (int 3.15)

  // string stuff
  // let str1 = "I can escape chars like \" with a backslash(\\)"
  // let str2 = @"I ignore backslashes \ \ \" // "verbatum" string (ignores backslashes)
  // let str3 = """ I Ignore double quotes " and backslashes \ """
  // let str4 = str2 + " " + str3

  // printfn("Length: %i") (String.length str4)
  // printfn ("1st Char: %c") (str1.[0])
  // printfn "1st Word: %s" (str1.[0..4])

  // let upper_str = String.collect (fun c -> sprintf "%c, " c) "commas"

  // printfn "Commas: %s" upper_str
  // printfn "Any upper: %b" (String.exists (fun c -> Char.IsUpper(c)) str1)
  // printfn "All Numbers: %b" (String.forall(fun c -> Char.IsDigit(c)) "1234")

  // let string1 = String.init 10 (fun i -> i.ToString())
  // printfn "Numbers: %s" string1

  // loop stuff

  // while loop
  // let magic_num = "7"
  // let mutable guess = ""

  // while not (magic_num.Equals(guess)) do
  //   printf "Guess the Number: "
  //   guess <- Console.ReadLine()

  // printfn "You Guessed the number %s" guess

  // for loop
  // for i = 1 to 10 do 
  //   printfn "%i" i

  // for i = 10 downto 1 do
  //   printfn "%i" i

  // for i in [1..10] do
  //   printfn "%i" i

  // [1..10] |> List.iter (printfn "Num: %i")

  // let sum = List.reduce(+) [1..10]
  // printfn "Sum: %i" sum

  // conditionals
  // let age = 8
  // if age < 5 then
  //   printfn "Preschool"
  // elif age = 5 then
  //   printfn "Kindergarten"
  // elif (age > 5) && (age <= 18) then
  //   let grade = age - 5
  //   printfn "Go to Grade %i" grade
  // else 
  //   printfn "Go to College"

  // let gpa = 3.9
  // let income = 15000
  // printfn "College Grant: %b" ((gpa >= 3.8) || (income <= 12000)) 
  // printfn "Not true: %b" (not true)

  // let grade2: string = 
  //   match age with
  //   | age when age < 5 -> "Preschool"
  //   | 5 -> "Kindergarten"
  //   | age when ((age > 5) && (age <= 18)) -> (age - 5).ToString()
  //   | _ -> "College"

  // printfn "Grade2: %s" grade2

  // list stuff
  // let list1 = [1;2;3;4]
  // list1 |> List.iter (printfn "Num: %i")
  // printfn "%A" list1
  
  // let list2 = 5::6::7::8::[] // "cons" operator?
  // printfn "%A" list2

  // let list3 = [1..5]
  // let list4 = ['a'..'g']
  // printfn "%A" list3
  // printfn "%A" list4

  // let list5 = List.init 5 (fun i -> i * 2)
  // printfn "%A" list5

  // let list6 = [ for a in 1..5 do yield (a * a)]
  // let list7 = [ for a in 1..20 do if a % 2 = 0 then yield a]
  // let list8 = [for a in 1..3 do yield! [a..a + 2]]
  // printfn "%A" list6
  // printfn "%A" list7
  // printfn "%A" list8
  // printfn "Length: %i" list8.Length
  // printfn "Empty: %b" list8.IsEmpty
  // printfn "Index 2: %c" (list4.Item(2))
  // printfn "Head: %c" (list4.Head)
  // printfn "Tail: %A" (list4.Tail)

  // let list9 = list3 |> List.filter (fun x -> x % 2 = 0)
  // let list10 = list3 |> List.map (fun x -> (x * x))
  
  // printfn "Sorted: %A" (List.sort [5;4;3])
  // printfn "Sum: %i" (List.fold (fun sum element -> sum + element) 0 [1;2;3]) 

// basics_demo()


// Enum stuff
// type emotion = 
// | joy = 0
// | fear = 1
// | anger = 2


// let enum_stuff() =
//   let myfeeling = emotion.joy

//   match myfeeling with
//   | joy -> printfn "I'm joyful"
//   | fear -> printfn "I'm scared"
//   | anger -> printfn "I'm mad"
  
// enum_stuff()


// // option stuff
// let options_stuff() =
//   let divide x y =
//     match y with
//     | 0 -> None
//     | _ -> Some (x / y)
//   if (divide 5 0).IsSome then
//     printfn("5 / 0 = %A") ((divide 5 0).Value)
//   elif (divide 5 0).IsNone then
//     printfn("Cannot divide by Zero")
//   else
//     printfn "Something happened"
  
//   // https://learn.microsoft.com/en-us/dotnet/fsharp/language-reference/options
//   let rec tryFindMatch pred list =
//     match list with 
//     | head :: tail -> if pred(head)
//                                       then Some(head)
//                                       else tryFindMatch pred tail
//     | [] -> None

//   let result1 = tryFindMatch (fun elem -> elem = 100) [200;100;50;25]
//   let result2 = tryFindMatch (fun elem -> elem = 36) [200;100;50;25]
//   printfn("Result1: %A") result1 // Some 100
//   printfn("Result2: %A") result2 // None

// options_stuff()


// tuple stuff
// let tuple_stuff() =
//   let avg (w, x, y, z) : float =
//     let sum = w + x + y + z
//     sum / 4.0

//   printfn "Avg: %f" (avg (1.0, 2.0, 3.0, 4.0))

//   let my_data = ("Derek", 42, 6.25)
//   let (name, age, _) = my_data
//   printfn "Name: %s" name
//   printfn "Age: %i" age

// tuple_stuff()

// record stuff
// type customer = 
//   { Name : string 
//     Balance : float }

// let record_stuff() =
//   let bob = { Name = "Bob"; Balance = 101.50 }
//   printfn "%s owes us %.2f" bob.Name bob.Balance

// record_stuff()

// sequences stuff
// let seq_stuff() =
//   let seq1 = seq { 1..100 }
//   let seq2 = seq { 0 .. 2 .. 50 } // only even numbers from 0-50
//   let seq3 = seq { 50..1 }

//   printfn "%A" seq1
//   printfn "%A" seq2
//   Seq.toList seq2 |> List.iter (fun x -> printfn "Num: %i" x)
//   printfn "%A" seq3
//   Seq.toList seq3 |> List.iter (fun x -> printfn "Num: %i" x)

//   let is_prime n =
//     let rec check i = 
//       i > n/2 || ( n% i <> 0 && check (i + 1))
//     check 2
  
//   let prime_seq = seq { for n in 1..500 do if is_prime n then yield n }
//   printfn "%A" prime_seq
//   Seq.toList prime_seq |> List.iter (printfn "Prime: %i")

// seq_stuff()

// map stuff
// let map_stuff() =
//   let customers = 
//     Map.empty
//       .Add("Bob", 100.50)
//       .Add("Sally", 1.10)
//       .Add("Zeke", 30.43)

//   printfn "%A" customers
//   printfn "# of Customers %i" customers.Count

//   let cust = customers.TryFind "Bob"
//   printfn "Bob owes us: %.2f" cust.Value
//   printfn "Bob owes us: %.2f" customers.["Bob"]

//   match cust with 
//     | Some x -> printfn "Balance: %.2f" x
//     | None -> printfn "Not found"

//   if customers.ContainsKey "Bob" then
//     printfn "Bob was found"
  
//   let custs2 = Map.remove "Zeke" customers
//   printfn "%A" custs2
//   printfn "# of Customers %i" custs2.Count

// map_stuff()

// generics - allows you to use any datatype in a func
// let add_stuff<'T> x y =
//   printfn "%A" (x + y)

// let generic_stuff() =
//   add_stuff<float> 3.9 2.2
//   add_stuff<int> 3 2

// generic_stuff()


// Exception stuff
// let exception_stuff() =
//   let divide x y =
//     try 
//       if y = 0 then 
//         raise (DivideByZeroException "Can't Divide by 0")
//       else
//         printfn "%i / %i = %i" x y (x / y)
//     with 
//       | :? DivideByZeroException as ex -> printfn "Can't Divide by Zero"
    
//   divide 5 4
//   divide 5 0

// exception_stuff()


// structs - allows you to create your own datatype
// type Rectangle = struct
//   val Length : float
//   val Width : float 

//   new (length, width) =
//     { Length = length; Width = width }
// end

// let struct_stuff() =
//   let area(shape: Rectangle) = 
//     shape.Length * shape.Width

//   let rect = new Rectangle (10.5, 20.5)
//   let rect_area = area rect
//   printfn "%A" rect
//   printfn "Area: %.2f" rect_area


// class stuff
type Animal = class
  val Name : string
  val Height : float
  val Weight : float

  new (name, height, weight) =
   { Name = name; Height = height; Weight = weight }

  member x.Run =
    printfn "%s Runs" x.Name
end

type Dog(name, height, weight) =
  inherit Animal(name, height, weight)

  member x.Bark =
    printfn "%s Barks" x.Name

let class_stuff() =
  let spot = new Animal("Spot", 20.5, 10.5)
  spot.Run

  let bowser = new Dog("Bowser", 20.5, 40.5)
  bowser.Run
  bowser.Bark

class_stuff()


// Console.ReadKey() |> ignore
