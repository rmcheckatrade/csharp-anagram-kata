# Csharp Anagram Kata
Write the code in `Anagram/AnagramFinder.cs` to check if two words are anagrams. 

Run tests with 

```shell
dotnet test --filter AnagramTests
```

Run benchmarks **AS AN ADMIN**, i.e. using `sudo` in unix environments, and as Administrator in windows.

```shell
dotnet test --filter AnagramBenchmarkTests --logger "console;verbosity=detailed"
```
