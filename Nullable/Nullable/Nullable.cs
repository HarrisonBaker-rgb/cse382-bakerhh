using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable;
public class Nullable {
	public static void g() {
		Console.WriteLine("Enter text");
		string? line = Console.ReadLine();

		if (line != null)
			Console.WriteLine(line.Length);
		else
			Console.WriteLine("Has no length");
	}
	public static string f(int v) {
		string str;
		if (v == 0)
			str = "some value";
		else
			str = "other value";
		return str;
	}
	public static int? Min(int[] arr) {
		if (arr == null || arr.Length == 0) {
			return null;
		}
		int min = arr[0];
		for (int i = 1; i<arr.Length; i++) {
			min = Math.Min(min, arr[i]);
		}
		return min;
	}

	public static void Main(String[] args) {
		g();

		Console.WriteLine("Array Minimum");
		int? min = Min(new int[] { });
		if (min.HasValue)
			Console.WriteLine(min);
		else
			Console.WriteLine("No min");
	}
}
