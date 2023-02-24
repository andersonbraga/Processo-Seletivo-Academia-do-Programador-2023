 Console.WriteLine("Hello user. Can you write measurements from first side of triangles ? ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello user. Can you write measurements from second side of trangles ? ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello user, Can you write measurements from third side of triangles ? ");
            double sideC = Convert.ToDouble(Console.ReadLine());
          

            if ( sideA == sideB &&  sideA == sideB && sideB == sideC )
                {
                    Console.WriteLine("Equilateral " );
                }
            else if  (sideA == sideB || sideA == sideC || sideB == sideC)
                {
                    Console.WriteLine("Isosceles ");
                }
            else 
                {
                    Console.WriteLine("Escaleno");
                    
                }