// Console.WriteLine("Hello, World!!!");

// int blarghie = 15;
// string name = "Bob ross";
// var boom = " " + 15.678;
// Console.WriteLine(blarghie + " " + name + boom);

//Array crud
//create
string[] favoriteRats = ["fancy rat", "brown rat", "radioactive rat"];

//read
foreach(var rat in favoriteRats)
{
  Console.WriteLine(rat);
}

//update
// this works but use linq favoriteRats[0] = "Fancy Rat";
var newFavoriteRats = favoriteRats.Where((e)=> e.StartsWith("b"));

foreach(var rat in newFavoriteRats)
{
  Console.WriteLine(rat);
}

//delete
//gimme can't really delete from an array well, according to instructor. 