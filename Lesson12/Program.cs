namespace Lesson12
{
	internal class Program
	{
		static void Main(string[] args)
		{

			User user1 = new("saxeli", "paroli");
			User user2 = new("saxeli", "paroli");


		    //if (user1 == user2) { }
			Console.WriteLine(user1.Equals(user2));  //true


			Console.WriteLine(user2.Equals(user1));



	       


			Player player1 = new("saxeli1", 202);
			Player player2 = new("saxeli2", 201);

			Console.WriteLine(player1.CompareTo(player2) );  // -1




			int[] number = { 100, 222, 3, 40, 5, 6, 7, 8, 9 };
			Array.Sort(number);

			Player[] players = { player1, player2 };
			Array.Sort(players);	





			//შექმენით პროდუქტის კლასი სახელი და ფასი
			//შექმენით მასივი 3 ობიექტით
			//დალაგეთ პროდუქტები ფასის ზრდადობით და დაბეჭდეთ ეკრანზე

		


				//შექმენით კლასი სახელით Car 
				//მოდელი და ძრავის მოძულობა
				//დაალაგეთ მანქანები ძრავის მოცულობის ზრდადობით


		}
	}
}
