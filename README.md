# Yet Another Workflow for Nuget

![CI build status](https://github.com/richtea/YAWN/actions/workflows/ci.yml/badge.svg)
![GitHub latest release](https://img.shields.io/github/v/release/richtea/YAWN?include_prereleases&sort=semver)

Contains a sample NuGet package, with a set of GitHub workflows that automate much of the development / release process.

See the [developer documentation](./docs/DEVELOPMENT.md) for information on how to follow the development / release
lifecycle.

## Main features

The interesting features of this repo are:

- Provides release automation support. Complex manual release steps are easy to forget or get wrong. Having automated
  tooling avoids both these issues. Releasing a new version is as simple as 1 - 2 - 3: 1) manually running a workflow to
  create a release PR; 2) merge the PR; and 3) publish the automatically-created GitHub release (which is created in
  draft mode). The developer documentation describes this process in more detail.

- Follows best practices from
  [Microsoft](https://learn.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices) and
  [Meziantou](https://www.meziantou.net/ensuring-best-practices-for-nuget-packages.htm) as closely as possible. The
  build / deploy workflows contain package validation to ensure that the quality doesn't accidentally drop.

- NuGet package properties are automatically configured. The package and repository URL properties use the repo URL by
  default.

- If you have set up [act](https://github.com/nektos/act) to run GitHub workflows locally, there is a supporting
  [script](./scripts/localbuild) to help you. Be aware that not all workflows can run locally, because act doesn't
  currently support [re-usable workflows](https://docs.github.com/en/actions/using-workflows/reusing-workflows).

- Repository labels are managed declaratively by editing the [config file](./.github/labels.yml).

## License

The scripts and documentation in this project are released under the [ISC License](./LICENSE).

## Credits

Package icon 'Under construction' created by max.icons -
[Flaticon](https://www.flaticon.com/free-icons/under-construction)

Pull Request and Tag icons by [Icons8](https://icons8.com)
