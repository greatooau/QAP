namespace QAP.RandomInstanceGenerator;
public class InstanceGenerator {


    /*
        private void generateInstance(int n, int v_min, int v_max, int w_min, int w_max) {
            
            Random random = new Random();

            // ReSharper disable once PossibleLossOfFraction
            double w = ((n * (w_max + w_min) /2 ) * 0.3);

            int vI = 0;
            int wI = 0;

            string[] files = Directory.GetFiles("./instances/");

            if(files.Length > 0) {
                            
                List<string> auxList = new List<string>();
                List<int> indexes = new List<int>();

                foreach (string file in files) {
                    char[] fileIndex = file.Replace("./instances/", "").ToCharArray();
                    foreach (char c in fileIndex) {
                        try {
                            if(Convert.ToInt32(c.ToString()).GetType().Equals(typeof(int))){
                                auxList.Add(c.ToString());
                            }
                        }
                        catch {}

                    }

                    indexes.Add(Convert.ToInt32(string.Join("", auxList)));
                    auxList.Clear();
                }

                using (StreamWriter sw = File.CreateText("./instances/outfile" + (indexes.Max() + 1) + ".txt")) {
                    sw.WriteLine($"{n},{w}");

                    foreach (var row in Enumerable.Range(1,n)) {
                        vI = random.Next(v_min, v_max + 1);
                        wI = random.Next(w_min, w_max + 1);
                        sw.WriteLine($"{vI},{wI}");
                    }
                    sw.Close();   
                }
            }
            else if (files.Length == 0) {
                using (StreamWriter sw = File.CreateText("./instances/outfile1.txt")) {

                    sw.WriteLine($"{n},{w}");

                    foreach (var row in Enumerable.Range(1,n)) {
                        vI = random.Next(v_min, v_max + 1);
                        wI = random.Next(w_min, w_max + 1);
                        sw.WriteLine($"{vI},{wI}");
                    }
                    sw.Close();   
                }
            }

            Thread.Sleep(3000);

        }

        private Dictionary<string,int> readData() {

            Dictionary<string,int> data = new Dictionary<string, int>();
            int n = 0, v_min = 0, v_max = 0, w_min = 0, w_max = 0;

            //Validate n
            while(true) {
                Console.WriteLine($"Instances generated: {_instanceCounter}");
                Console.WriteLine($"\nInstance #{_instanceCounter + 1}");
                Console.WriteLine($"n = {n}, v_min = {v_min}, v_max = {v_max}, w_min = {w_min}, w_max = {w_max}\n");
                Console.WriteLine("Enter the number of objects: ");

                try {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Enter a number");
                    Thread.Sleep(2000);
                    continue;
                }

                if(n <= 0) {
                    Console.WriteLine("\nThe number of objects must be greater than 0.\n");
                    continue;
                }
                else {
                    break;
                }

            }
            
            //Validate v_min
            
            while(true) {
                Console.WriteLine($"Instances generated: {_instanceCounter}");
                Console.WriteLine($"\nInstance #{_instanceCounter + 1}");
                Console.WriteLine($"n = {n}, v_min = {v_min}, v_max = {v_max}, w_min = {w_min}, w_max = {w_max}\n");
                Console.WriteLine("Enter the minimum value of the objects of the instance: ");

                try {
                    v_min = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Enter a number");
                    Thread.Sleep(2000);
                    continue;
                }

                if(v_min <= 0) {
                    Console.WriteLine("\nThe minimum value must be greater than 0.\n");
                    continue;
                }
                else {
                    break;
                }

            }
            
            //Validate v_max
            
            while(true) {
                Console.WriteLine($"Instances generated: {this._instanceCounter}");
                Console.WriteLine($"\nInstance #{this._instanceCounter + 1}");
                Console.WriteLine($"n = {n}, v_min = {v_min}, v_max = {v_max}, w_min = {w_min}, w_max = {w_max}\n");
                Console.WriteLine("Enter the maximum value of the objects of the instance: ");

                try {
                    v_max = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Enter a number");
                    Thread.Sleep(2000);
                    continue;
                }

                if(v_max <= v_min) {
                    Console.WriteLine("\nMaximum value must be greater than minimum.\n");
                    Thread.Sleep(2000);
                    continue;
                }
                else {
                    break;
                }

            }
            
            //Validate w_min
            
            while(true) {
                Console.WriteLine($"Instances generated: {_instanceCounter}");
                Console.WriteLine($"\nInstance #{this._instanceCounter + 1}");
                Console.WriteLine($"n = {n}, v_min = {v_min}, v_max = {v_max}, w_min = {w_min}, w_max = {w_max}\n");
                Console.WriteLine("Enter the minimum weight of the objects of the instance: ");

                try {
                    w_min = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Enter a number");
                    Thread.Sleep(2000);
                    continue;
                }

                if(w_min <= 0) {
                    Console.WriteLine("\nThe minimum weight must be greater than 0.\n");
                    Thread.Sleep(2000);
                    continue;
                }
                else {
                    break;
                }

            }
            
            //Validate w_max
            
            while(true) {
                Console.WriteLine($"Instances generated: {this._instanceCounter}");
                Console.WriteLine($"\nInstance #{this._instanceCounter + 1}");
                Console.WriteLine($"n = {n}, v_min = {v_min}, v_max = {v_max}, w_min = {w_min}, w_max = {w_max}\n");
                Console.WriteLine("Enter the maximum weight of the objects of the instance: ");

                try {
                    w_max = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    Console.WriteLine("Enter a number");
                    Thread.Sleep(2000);
                    continue;
                }

                if(w_max <= w_min) {
                    Console.WriteLine("\nMaximum weight must be greater than minimum.\n");
                    Thread.Sleep(2000);
                    continue;
                }
                else {
                    break;
                }

            }
            
            data.Add("n", n);
            data.Add("v_min", v_min);
            data.Add("v_max", v_max);
            data.Add("w_min", w_min);
            data.Add("w_max", w_max);
            
            return data;

        }*/

}