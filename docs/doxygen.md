# Doxygen API documentation

Doxygen generates a browsable C# API reference, including namespaces, classes, and their methods. The current source documents the `itester` namespace, `Program`, `Calculator`, `Main`, and the calculator operations. `EXTRACT_ALL` also includes symbols that do not yet have XML documentation comments; adding `///` comments provides the descriptions shown on their API pages.

## Requirements

- Doxygen 1.9 or later

## Generate the documentation

Run this from the repository root:

```sh
doxygen Doxyfile
```

The generated HTML site is written to `docs/doxygen/html/`. Open `docs/doxygen/html/index.html` in a browser. Doxygen also emits XML output in `docs/doxygen/xml/` for tooling that consumes XML documentation.

The HTML uses a custom black-neon theme defined in `docs/doxygen-dark.css`. The configuration scans all `*.cs` files recursively, so API types added in subdirectories are included automatically.
