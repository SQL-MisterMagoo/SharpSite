# Contributing to SharpSite

Thank you for your interest in contributing to SharpSite! Your contributions are valuable and help improve the project for everyone. Here's how you can get started:


## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)


## Getting Started

1. Fork the repository to your GitHub account.
2. Clone the forked repository to your local machine using:

```
git clone https://github.com/YOUR-USERNAME/SharpSite.git
```

3. Create a new branch for your feature or bugfix:

```
git checkout -b feature_your-feature-name
```

## Development Setup

1. Ensure you have .NET 9 SDK installed on your machine.
2. Configure Docker or Podman on your machine.  We will use this with .NET Aspire.  More details about configuring and using .NET Aspire can be found at: https://learn.microsoft.com/dotnet/aspire/fundamentals/setup-tooling
3. Install the necessary dependencies.  From the root folder, run this command:

```
dotnet restore
```

3. Build the project from the **SharpSite.AppHost** folder:

```
dotnet build
```

4. Install development certificates for local development.

Generate a new HTTPS development certificate:
```bash
dotnet dev-certs https --trust
```

Export the HTTPS development certificate:
```bash
dotnet dev-certs https -ep path/to/certificate.pfx -p yourpassword
```

Verify the HTTPS development certificate:
```bash
dotnet dev-certs https --check --trust
```

5. Run the project locally with .NET Aspire from the **SharpSite.AppHost** folder:

```
dotnet run
```

## Default User

The default user that is built and initialized in SharpSite is an Administrator and has these credentials:
- username: `admin@localhost`
- password: `Admin123!`

## Coding Guidelines

- Follow the C# coding conventions as outlined in the [Microsoft C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions).
- Keep code changes concise and focused.
- Write clear, descriptive commit messages.

## Adding Translations

To add translations for a new locale, follow these steps:

1. **Add a .resx File**:
    - Navigate to the `SharpSite.Web/Locales` folder in the project.
    - Add a new `.resx` file with the appropriate naming convention, e.g., `SharedResource.<locale>.resx` (e.g., `SharedResource.fr.resx` for French).
    - Add the necessary key-value pairs for the translations in the `.resx` file.

2. **Update Locales Configuration**:
    - Open `Locales/Configuration.cs`.
    - Add an entry for the new locale in the appropriate configuration section. For example:

      ```csharp
      public static class Configuration
      {
        public readonly static string[] SupportedCultures = {
           "en-US",
           "nl-NL"
            // Add your new locale here
           "<locale>"
        };
        ...
      }

      ```

3. **Verify Translations**:
    - Ensure that the translations are correctly loaded and displayed in the application.
    - Test the application with the new locale to verify that all translations are working as expected.

## Submitting Changes

1. Ensure all tests pass before submitting a pull request.
2. Update documentation as needed.
3. Push your branch to your forked repository:

```
git push origin feature_your-feature-name
```

4. Open a pull request against the `main` branch of the original repository.

## Reporting Issues

If you find a bug or have a feature request, please [open an issue](https://github.com/FritzAndFriends/SharpSite/issues) on GitHub. Provide as much detail as possible to help us address the issue quickly.

## Lead Project Maintainer

[Jeff Fritz](https://github.com/csharpfritz) is the lead project maintainer. Feel free to reach out to him for any significant inquiries or guidance regarding SharpSite.

## Code of Conduct

We adhere to the Contributor Covenant [Code of Conduct](https://www.contributor-covenant.org/version/2/0/code_of_conduct/). By participating, you are expected to uphold this code.

## License

By contributing to SharpSite, you agree that your contributions will be licensed under the [MIT License](LICENSE).
