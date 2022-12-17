# Developer documentation

This file contains notes to support anyone developing this project.

## Development workflow

![Workflow overview](./release_workflow.drawio.svg)

### 0. Make changes

This is a typical trunk-based workflow. You will probably repeat this several times between each release.

For each change:

- Create a branch (direct pushes to `main` are prohibited). Prefix the descriptive name with `feature/*` or `bugfix/*`
  to provide a hint as to the motivation for the change. If there's a related issue, it's handy to start the descriptive
  name with the issue number e.g. `feature/123-awesome-change`.

- Make your changes. Don't forget to update the `Unreleased` section of the changelog with a description of your
  changes!

- When your branch is ready to merge, create a [pull request](./pulls) that targets the `main` branch. This triggers
  some CI workflows to validate the changes.

### 1. Release a new version

Releases always start on the `main` branch. When `main` is ready to release, run the `[autorelease] Prepare release PR`
workflow. The parameters are:

- __Use workflow from:__ `main`

- __Release type:__ Select the appropriate value that defines how the release number will be incremented. See the
  documentation for the [semver library](https://www.npmjs.com/package/semver#user-content-functions)'s `inc` function
  for more details.

- __Pre-release identifier:__ The pre-release prefix, e.g. `alpha`, `beta` etc.

This workflow creates a PR containing a commit that updates the changelog by modifying the `[Unreleased]` section title
to contain the incremented version number.

#### Release type notes

How to choose a release type? The documentation for the semver `inc` function isn't extensive. Here are some examples, I
will write a full description later.

##### Examples

| Latest release   | release-type | prerelease-identifier | Result            |
| ---------------- | ------------ | --------------------- | ----------------- |
| `unreleased`     | prerelease   | `alpha`               | `0.0.1-alpha.0`   |
| `unreleased`     | preminor     | `alpha`               | `0.1.0-alpha.0`   |
| `0.1.0-alpha.1`  | prerelease   | `alpha`               | `0.1.0-alpha.2`   |
| `0.1.0-alpha.1`  | prerelease   | _empty_               | `0.1.0-alpha.2`   |
| `0.1.0-alpha.1`  | prerelease   | `beta`                | `0.1.0-beta.0`    |
| `0.1.0-beta.0`   | prerelease   | _empty_               | `0.1.0-beta.1`    |
| `0.1.0-beta.1`   | minor        | _empty_               | `0.1.0`           |
| `0.1.0-beta.1`   | preminor     | `alpha`               | `0.2.0-alpha.0`   |
| `0.1.0-beta.1`   | preminor     | `beta`                | `0.2.0-beta.0`    |
| `0.1.0-beta.1`   | minor        | `beta`                | `0.1.0`           |
| `0.1.0-beta.1`   | minor        | `alpha`               | `0.1.0`           |
| `0.1.0`          | prerelease   | `alpha`               | `0.1.1-alpha.0`   |


### 2. Merge the release PR

When you merge the PR back onto `main`, this triggers the release process. A workflow creates the release and attaches
the NuGet package as a release asset. The release is created in draft mode.

### 3. Publish the release

When you publish the release through the GitHub UI, the NuGet package is automatically pushed to the NuGet feed.
