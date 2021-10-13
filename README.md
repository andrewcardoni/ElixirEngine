<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Codacy][codacy-shield]][codacy-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<!-- PROJECT LOGO -->
<br />
<p align="center">
  <a href="https://github.com/RichardPreziosi/ElixirEngine">
    <img style="width: 80px; height: 80px;" src=".github/elixir-engine-logo.png" alt="Logo">
  </a>

  <h3 align="center">Elixir Engine</h3>

  <p align="center">
    Elixir Engine is a 2D game engine, utilizing <a href="https://github.com/dotnet/Silk.NET" target="_blank">Silk.NET</a>, <a href="https://www.opengl.org" target="_blank">OpenGL</a> and <a href="https://docs.microsoft.com/en-us/dotnet/" target="_blank">.NET 5</a>, that focuses on proper separation of concerns and dependency injection.
    <br />
    <a href="https://RichardPreziosi.github.io/ElixirEngine/"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/RichardPreziosi/ElixirEngine">View Demo</a>
    ·
    <a href="https://github.com/RichardPreziosi/ElixirEngine/issues">Report Bug</a>
    ·
    <a href="https://github.com/RichardPreziosi/ElixirEngine/issues">Request a Feature</a>
  </p>

<!-- TABLE OF CONTENTS -->
## Table of Contents

*  [About the Project](#about-the-project)
     * [Built With](#built-with) 
     
*  [Getting Started](#getting-started)
     * [Prerequisites](#prerequisites)
     * [Installation](#installation)
     
*  [Usage](#usage)
*  [Roadmap](#roadmap)
*  [Contributing](#contributing)
*  [License](#license)
*  [Acknowledgements](#acknowledgements)

<!-- ABOUT THE PROJECT -->
## About The Project

This is just a fun project to implement a 2D game engine utilizing [Silk.NET][silk-url] and [OpenGL][opengl-url] while taking advantage of dependency injection.

Elixir Engine focuses on separating data from behavior by promoting composition of entities. This is achieved by composing entities of both components and behaviors.

### Built With

* [Silk.NET][silk-url]
* [OpenGL][opengl-url]
* [.NET 5][dotnet-url]
* [Microsoft.Extensions.DependencyInjection][dependencyinjection-url]
* [Microsoft.Extensions.Logging][logging-url]

<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple steps.

### Prerequisites

None

### Installation

1. Clone the repo
```sh
git clone https://github.com/RichardPreziosi/ElixirEngine.git
```

<!-- USAGE EXAMPLES -->
## Usage

_For more examples, please refer to the [Documentation](https://example.com)_

<!-- ROADMAP -->
## Roadmap

See the [open issues](https://github.com/RichardPreziosi/ElixirEngine/issues) for a list of proposed features (and known issues).

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE` for more information.

<!-- ACKNOWLEDGEMENTS -->
## Acknowledgements

*  [OpenGL][opengl-url]

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[codacy-shield]: https://app.codacy.com/project/badge/Grade/f15d062aa3214032aa3b45e629f6002c
[codacy-url]: https://www.codacy.com/gh/RichardPreziosi/ElixirEngine/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=RichardPreziosi/ElixirEngine&amp;utm_campaign=Badge_Grade
[forks-shield]: https://img.shields.io/github/forks/RichardPreziosi/ElixirEngine.svg?style=flat-square
[forks-url]: https://github.com/RichardPreziosi/ElixirEngine/network/members
[stars-shield]: https://img.shields.io/github/stars/RichardPreziosi/ElixirEngine.svg?style=flat-square
[stars-url]: https://github.com/RichardPreziosi/ElixirEngine/stargazers
[issues-shield]: https://img.shields.io/github/issues/RichardPreziosi/ElixirEngine.svg?style=flat-square
[issues-url]: https://github.com/RichardPreziosi/ElixirEngine/issues
[license-shield]: https://img.shields.io/github/license/RichardPreziosi/ElixirEngine.svg?style=flat-square
[license-url]: https://github.com/RichardPreziosi/ElixirEngine/blob/main/LICENSE
[silk-url]: https://github.com/dotnet/Silk.NET
[opengl-url]: https://www.opengl.org
[dotnet-url]: https://docs.microsoft.com/en-us/dotnet/
[dependencyinjection-url]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection?view=dotnet-plat-ext-5.0
[logging-url]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging?view=dotnet-plat-ext-5.0

