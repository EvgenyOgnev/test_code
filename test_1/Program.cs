
string [] array = { "< ","Hello","World","333","22","home","qwer","ww" };

for (int i = 0; i < array.Length; i++)
{
    string f = array [i];
    int j = 0;
    if (f.Length < 4)
    {
        array [j] = f;
        Console.WriteLine(array[j]);
    }
    j++;
}

