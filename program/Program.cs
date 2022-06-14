using System;

const int LEN_LIMIT = 3;

/// <summary>
/// reads a string from terminal and returns false on error and string array
/// </summary>
bool grabStrings(ref string[] stringArray){    
    Console.Write("Enter words separated by a space > ");
    string? someString = Console.ReadLine();
    if(null == someString)
        return false;
    stringArray = someString.Split(" ");
    return true;
}

void printResults(in string[] inputArray, in string[] outputArray){
    Console.Write("[");
    for(int i = 0; i < inputArray.Length; i++){
        Console.Write($"{inputArray[i]} ");
    }
    Console.Write("] -> [");
    for(int i = 0; i < outputArray.Length; i++){
        Console.Write($"{outputArray[i]} ");
    }
    Console.WriteLine("]");
}

/// <summary>
/// main task
/// </summary>
void homework(){
    string[] stringArray = {};
    string[] resultArray = {};    
    int lenLimit = LEN_LIMIT;

    if(!grabStrings(ref stringArray)){
        Console.WriteLine("Error in reading");
        return;
    }

    int cntr = 0;
    for(int i = 0; i < stringArray.Length; i++){
        if(null == stringArray[i])
            continue;
        if(stringArray[i].Length <= lenLimit){
            Array.Resize(ref resultArray, resultArray.Length + 1);
            resultArray[cntr] = stringArray[i];
            cntr++;
        }
    }

    printResults(in stringArray, in resultArray);
}

void Main(){
    homework();
}

Main();
