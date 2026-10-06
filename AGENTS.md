# Agent integration guidance

For SDK, Logic Apps Bundle, or VS Code integration testing, start with
[`tests\ExtensionE2E\README.md`](tests/ExtensionE2E/README.md). It is the central
three-repository runbook; follow the companion guides it identifies for
repository-specific prerequisites.

- Ask for missing repository/tool paths and the intended runtime revision.
  Do not assume another agent's session directories, installed profile, or
  cached package is available.
- Build complete versioned SDK packages and genuine source-built bundles.
  Use verified manifests, fresh candidate roots, and copied test workspaces;
  never overlay loose DLLs or replace shared SDK/bundle caches.
- Preserve user source, configuration, credentials, unsaved edits, and existing
  candidates. Editor/task termination, relaunch, sign-in, and connector/workflow
  execution require the user's authorization. Do not kill port owners or
  bypass workspace trust.
- Treat archive preparation, extension pickup, build, owned-host startup,
  debugger attachment, workflow execution, and designer inspection as separate
  acceptance gates. Report only the gates supported by current evidence.
- Check actual JSON outputs and unknown-field/null preservation, not just
  compilation or expression text. Preserve typed numeric/date/custom formatting
  and do not restore removed custom-type or Response workarounds.
- Keep receipts and private settings outside repositories; redact credentials,
  callback signatures, storage keys, and authentication tokens from reports.
- When authorized to publish, verify the user's approved non-EMU GitHub account
  rather than assuming the tool's default identity; this integration was
  published using `lambrianmsft`. Do not change shared authentication state.
  A pushed branch or open PR is not evidence that runtime tests passed.
