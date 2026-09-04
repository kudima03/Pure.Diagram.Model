# Changelog

All notable changes to Pure.Diagram.Model are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **Breaking:** `Series` renamed to `DiagramSeries`, and its abstraction
  `ISeries` to `IDiagramSeries`. `Diagram.Series` and the corresponding
  constructor parameter changed from `IEnumerable<ISeries>` to
  `IEnumerable<IDiagramSeries>`.
- Package validation enabled (`EnablePackageValidation`) with baseline
  version `0.1.0-preview.0.1.0`, guarding against future breaking API
  changes.
- Dependency on `Pure.Diagram.Model.Abstractions` bumped to
  `0.1.0-preview.1.0.0`.

## [0.1.0-preview.0.1.0] — 2026-02-09

### Added

- Initial release of the model.
- **`Diagram`** — sealed record implementing `IDiagram`, composed of
  `Title`, `Description`, `Type` (`IDiagramType`), and `Series`
  (`IEnumerable<ISeries>`).
- **`DiagramType`** — sealed record implementing `IDiagramType`, wrapping
  a `Name` (`IString`).
- **`Series`** — sealed record implementing `ISeries`, with `Label` and
  `Source` (`IString`).
- NuGet package metadata (license, project URL, authors) and a reference
  to `Pure.Diagram.Model.Abstractions`.
