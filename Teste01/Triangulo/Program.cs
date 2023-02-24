 Console.WriteLine("Digita a  primeira medida do triangulo  ");
            double sideA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda medida do triangulo ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira medida do triangulo");
            double sideC = Convert.ToDouble(Console.ReadLine());
          
          if( sideA < sideB + sideC)
          {
            
            if(sideB < sideA + sideC)
            {
              if(sideC < sideA + sideB)
              {
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
              }
            }
          }
          else {
            Console.WriteLine("Essas medidas não são de um triangulo");
          }

           