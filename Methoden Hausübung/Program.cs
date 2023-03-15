static bool Contains(string toSearch, char target)

{
    bool targetFound=false;
    for (int i = 0; i < toSearch.Length; i++)
    {
       if (toSearch[i] == target){
        targetFound = true;
        return targetFound;
       }
    }
    return targetFound;
}

static int IndexOf(string search, char target)

{
    for (int i = 0; i < search.Length; i++)
    {
        if(target == search[i] ){
            return i;
        }
    }
    return -1;
    
}
static int LastIndexOf(string search, char target)
{
    int lastIndexOf = -1;

    for (int i = 0; i < search.Length; i++)
    {
        if(target == search[i]){
            lastIndexOf = i;
        }
    }
    return lastIndexOf;
}

static string TrimStart(string toSearch, char target)
{
    string newString = "";
    bool continueSearch = true;
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (toSearch[i] != target)
        {
            continueSearch = false;
        }

        if (continueSearch == false)
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

static string TrimEnd(string toSearch, char target)
{
    string newString = "";
    bool continueSearch = true;
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (target != toSearch[i])
        {
            continueSearch = false;
        }

        if (continueSearch || target != toSearch[i])
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

static string Trim(string toSearch, char target)
{
    string newString = "";
    for (int i = 0; i < toSearch.Length; i++)
    {
        if (toSearch[i] != target)
        {
            newString += toSearch[i];
        }
    }
    return newString;
}

static string SubString(string toSub, int index, int max)
{
    string newString = "";
    for (int i = index; i < toSub.Length; i++)
    {
        if (newString.Length < max)
        {
            newString += toSub[i];
        }
    }
    return newString;
}

static string Remove(string toRemove, int index, int max)
{
    int count = 0;
    string newString = "";
    for (int i = 0; i < toRemove.Length; i++)
    {
        if (i < index)
        {
            newString += toRemove[i];
        }
        else
        {
            if (count >= max)
            {
                newString += toRemove[i];
            }
            count++;
        }
    }
    return newString;
}
