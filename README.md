# NuGetWorkflow

![CI build status](https://github.com/richtea/NuGetWorkflow/actions/workflows/ci.yml/badge.svg)
![GitHub latest release](https://img.shields.io/github/v/release/richtea/NuGetWorkflow?include_prereleases&sort=semver)

Contains a sample NuGet package, with a set of GitHub workflows for managing the development / release lifecycle.

See the [developer documentation](./docs/DEVELOPMENT.md) for information on using the development lifecycle.

## Main features

The main interesting features of this repo are:

- Contains as much automation as possible. A release can be as simple as manually running a workflow to create a release
  PR; merge the PR; and publish the automatically-created GitHub release (which is created in draft mode).

- NuGet package properties are automatically configured. The package and repository URL properties use the repo URL by
  default.

- If you have set up [act](https://github.com/nektos/act) to run GitHub workflows locally, there is a supporting
  [script](./scripts/localbuild) to help you (though not all workflows can run locally, because act doesn't support
  [re-usable workflows](https://docs.github.com/en/actions/using-workflows/reusing-workflows) currently).

- Repository labels are managed declaratively by editing [a file](./.github/labels.yml).

## License

The scripts and documentation in this project are released under the [ISC License](./LICENSE).

## Credits

Package icon 'Under construction' created by max.icons - [Flaticon](https://www.flaticon.com/free-icons/under-construction)
