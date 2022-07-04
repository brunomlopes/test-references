# test-references

Quick test to see how we could handle referencing .net 4.8 solutions/dlls from a .net 6 project.

This fails with 
```
Error	CS0012	The type 'Container' is defined in an assembly that is not referenced. You must add a reference to assembly 'ServiceStack, Version=6.0.0.0, Culture=neutral, PublicKeyToken=02c12cbda47e6587'.	CoreWebSss	C:\Users\brunomlopes\source\repos\TestReferences\CoreWebSss\Configure.AppHost.cs	21	N/A
```

Servicestack cross-compiles to .net 4.72, .net 6 and .net standard, as shown on the package contents: 

![image](https://user-images.githubusercontent.com/83034/177144115-5e766bf1-06e0-464c-8729-9928f4ec4137.png)

This means, AFAIK, that .net 6 should reference one file and .net 4.7.2 should reference another. 

We could fix that by referencing the .net 4.7.2 files directly on the .net 6 project, but that might blow up in our faces in runtime, when it uses code that does not exist in .net 6.
Also, we would have to copy into our project all code related to setting up asp.net core.

### Conclusion

I think that having a separate .net core project will not work until we move the critical parts to .net core.

We might move the better part of the code to .net core.
