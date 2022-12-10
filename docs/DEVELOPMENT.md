# Developer documentation

This file contains notes to support anyone developing this project.

## Development workflow

### Make a change

- Create a branch (direct pushes to `main` are prohibited). Prefix the descriptive name with `feature/*` or `bugfix/*`
  to provide a hint as to the motivation for the change. If there's a related issue, it's handy to start the descriptive
  name with the issue number e.g. `feature/123-awesome-change`.

- When your branch is ready to merge, create a [pull request](./pulls) that targets the `main` branch. This triggers
  some CI workflows to validate the changes.

### Release a new version

Releases always start on the `main` branch. When `main` is ready to release, run the `[autorelease] Prepare release PR`
workflow. The parameters are:

- __Use workflow from:__ `main`

- __Release type:__ Select the appropriate value that defines how the release number will be incremented. See the
  documentation for the [semver library](https://www.npmjs.com/package/semver#user-content-functions)'s `inc` function
  for more details.

- __Pre-release identifier:__ The pre-release prefix, e.g. `alpha`, `beta` etc.

This workflow creates a PR containing a commit that updates the changelog by modifying the `[Unreleased]` section title
to contain the incremented version number.

When you merge the PR back onto `main`, this triggers the release process. A workflow creates the release and attaches
the NuGet package as a release asset. The release is created in draft mode.

When you publish the release through the GitHub UI, the NuGet package is automatically pushed to the NuGet feed.
