# Pure.Diagram.Model

Concrete implementations of the diagram domain model for the **Pure** ecosystem — immutable, AOT-compatible records implementing the `Pure.Diagram.Model.Abstractions` contracts.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.Model/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.Model/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.Model)](https://www.nuget.org/packages/Pure.Diagram.Model)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.Model` provides sealed record implementations of the diagram abstractions defined in [`Pure.Diagram.Model.Abstractions`](https://github.com/kudima03/Pure.Diagram.Model.Abstractions). Each type is immutable by construction and depends on [`IString`](https://github.com/kudima03/Pure.Primitives.Abstractions) from `Pure.Primitives.Abstractions` for all string-valued properties.

## Types

| Type | Implements | Description |
|------|-----------|-------------|
| `Diagram` | `IDiagram` | Root diagram record — holds title, description, type, and a series collection |
| `DiagramSeries` | `IDiagramSeries` | A data series with a label and source column binding |
| `DiagramType` | `IDiagramType` | Named diagram type (e.g. flow, sequence, class) |

All types reside in the `Pure.Diagram.Model` namespace.

## Design Principles

- **Immutable** — all properties are init-only; values are set once in the constructor and never changed.
- **Composable** — `Diagram` aggregates `IDiagramType` and `IEnumerable<IDiagramSeries>`, all of which are abstractions.
- **AOT-compatible** — sealed records with no reflection or dynamic dispatch.

## Dependencies

- [`Pure.Diagram.Model.Abstractions`](https://github.com/kudima03/Pure.Diagram.Model.Abstractions) — diagram domain interfaces
- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — `IString` interface
