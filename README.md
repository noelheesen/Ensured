# Ensured
A light-weight guard with a focus on simplicity and extensibility.

badges here...


```csharp
int x = Ensure.NotNull(1);

int y = Ensure.That(x).IsPositive();

//which internally calls:

int z = Ensure.Condition(y, yVal => yVal > 0); 
```

See the **[Wiki](/wiki)** for API and documentation.


## NuGet

[NuGet](https://www.nuget.org/packages/Ensured/)

```
install-package Ensured
```

Ensured is a **_portable class library_** that targets:

- .NET Framework 4.5
- ASP.NET Core 1.0
- Windows 8
- Windows Phone 8.1
- Xamarin.Android
- Xamarin.iOS
- Xamarin.iOS (classic)
- Xamarin.Mac


## Philosophy

Readability and maintainability of code are crucial for a reliable product. By demanding valid parameters decisions are forced to be made higher up which leads to cleaner code. 

My goal is to provide a uniform way of demanding valid parameters without much overhead of creating objects. Yes, an `ArgumentContext` is created each time `Ensure.That()` is called but it allows Ensured to be extended for platform specific validations and has the bonus of increasing the functionality.

Ensured should not restrict in any way so the value always gets returned when passing validation.


## Contribute

Want to help me keep code clean and maintainable? 

1. Clone the repository and make sure you are on the develop branch;
2. Create a new branch: `git-checkout -b feat-support-for-types`;
	* Branch names should start with `fix-` or `feat-`;
3. Implement the awesome fix / feature;
4. Update / write the tests;
5. Run the tests :smirk: and continue only if they pass;
6. Push the newly created branch: `git-push origin feat-support-for-types`;
7. Create a pull request.

For more information about conventions see [Contribute](../../Contribute.md)

## RoadMap

- [ ] Ensure Types;
- [ ] Ensure I/O;
- [ ] Ensure Streams;
- [ ] Get 100% test coverage ([Fixie](https://github.com/fixie/fixie));
- [ ] Create Documentation via XML comments;
- [ ] Create WIKI;
- [ ] Add support for custom exceptions _(without much overhead)_;
- [ ] Add support to pass in the exception to a callback action;
- [ ] Implement different message handling???;

## License

[MIT](../../License.txt)
