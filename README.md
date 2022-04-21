<div id="top"></div>

## Motivation

Visual studio (VS) 2022 then execute Text Template (*.tt) not need link assembly EnvDTE to have access to Visual Studio interop. In same time previous Visual studio 2019 and above need this assembly directive. It make use Text Templates more complicate in teams with different VS version and require have two version of each TT file depend on EnvDTE.
To cross gap we make bridge provide custom directive command 
<#@ EnvDTEResolve Processor="EnvDteDirectiveProcessor" #> and 2 Visual studio extensions to make TT files executable for different VS vesrsion. 

<p align="right">(<a href="#top">back to top</a>)</p>


### Built With

* [Visual Studio 2022]( https://visualstudio.microsoft.com/ru/vs/)


<!-- GETTING STARTED -->
## Getting Started
Usage:
1. Replace  ```<#@ assembly name="EnvDTE" #>``` 
with ```<#@ EnvDTEResolve Processor="EnvDteDirectiveProcessor" #>``` 
in each *.tt or *.ttinclude  file where need.
2. Install extension for VS 2017 – VS 2022 or VS 2022 depend on your installed version.

<p align="right">(<a href="#top">back to top</a>)</p>

## T4 Different output File Save Path Extensions for Visual Studio
- [T4.FileManager.VisualStudio]( https://github.com/databinding-gmbh/T4.FileManager.VisualStudio)
- [T4.FileManager.VisualStudio fork with binary](https://github.com/nobyArdor/T4.FileManager.VisualStudio)

## T4 Different output File Save Path Extensions for Visual Studio
- [tangible T4 Editor](https://t4-editor.tangible-engineering.com/T4-Editor-Visual-T4-Editing.html)
- [T4Editor](https://github.com/Tim-Maes/T4Editor)
- [devart T4 Editor](https://www.devart.com/t4-editor/)
- [T4Language](https://github.com/bricelam/T4Language)


<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#top">back to top</a>)</p>

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

Project Link: [https://github.com/your_username/repo_name](https://github.com/your_username/repo_name)

<p align="right">(<a href="#top">back to top</a>)</p>


