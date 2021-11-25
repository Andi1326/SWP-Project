# SWP-Project
1. git status - results in the console showing you, where there Merge Conflicts appeared.
2. Open the files individually in a Text Editor
3. Decide which changes you want to keep, they are marked the following:

>\<<<<<<< HEAD  
>Code 1  
>\=======  
>Code 2  
>\>>>>>> origin/otherBranch  
  
Meaning: You can either keep Code 1 (Original Code in this Branch) or Code 2 (Code from the Branch you're trying to merge) - most of the time you want to keep Code2  
  
4. After you went through all Changes (merged the conflicts by hand) you check once more, if everything was done correctly.
> git status

5. If everything is as expected (everything green), you add the files, commit and push them.
> git add .
> git commit -m "Whatever Message"
> git push
