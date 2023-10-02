using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS;
public class ComplexNumber {
    private double r, i; // Real part and imaginary part
    public ComplexNumber() : this(0, 0) { // default constructor. automatically passes in 0 and 0 for values.
    }
    public ComplexNumber(double real, double imag) {
        r = real;
        i = imag;
    }
    public override string ToString() { // can override.
        if (i < 0) {
            return string.Format("({0}{1}i)", r, i);
        } else {
            return string.Format("({0}+{1}i)", r, i);
        }
    }

    // java
    // student.setName("Fred");
    // student.getName();
    // c#
    // this instead is a property.
    // c1.Real = 5; (set)
    // console.WriteLine(c1.Real); (get)
    // no parentheses we use it as a data member.
    // we do not call get or set.
    // property means a setter and getter setup.
    public double Real {
        get {
            return r;
        }
        set {
            r = value;
        }
    }

    public double Imaginary {
        get {
            return i;
        }
        set {
            i = value;
        }
    }
    public static void ComplexMain() {
        ComplexNumber c1 = new ComplexNumber();
        ComplexNumber c2 = new ComplexNumber(2, 3);
        ComplexNumber c3 = new ComplexNumber {
                                Real = 45,
                                Imaginary = 22
                            };
        Console.WriteLine(c1);
        Console.WriteLine(c2);
        Console.WriteLine(c3);
    }
}