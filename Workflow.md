# Guide To Github Workflow - Pab15 

In this guide, I will lay out how I personally use git/github to:
- Create branches
- Commit to branches
- Push from branches
- Create a pull request
I will also go over some things you want to avoid doing.


---

## Powershell:
Note: This section only applies to windows, for MacOS and Linux, Git should be installed automatically.
- If you haven't already, [download git](https://git-scm.com/download/win) 
- Follow the install directions
- Once completed, verify that Git is installed by opening powershell and running `git` in the shell. The output should match the output provided below:
![Expected Git Output](WorkflowExamples/gitout.PNG)

---

## Creating a branch:
- In Powershell or Terminal, navigate to the cloned repository file
- To create the branch, run `git checkout -b <username+briefdescription>`. An example is provided below:
![New Branch](WorkflowExamples/exbranch.PNG)
- Congrats! You created a new branch, and are now working under that branch.

## Commiting and pushing changes:
Note: DO NOT commit any changes unless you are working in a new branch
- First, make sure that you have staged your changes by running the command `git add .`
Note: You will not see any output from this command, do not be alarmed.
- Next, commit your changes by running `git commit -m "<commit message>"` 
- Finally, push your changes by running `git push`
![Commit And Push](WorkflowExamples/exbranch.PNG)