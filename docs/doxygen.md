# Doxygen API documentation

This repository uses Doxygen to generate API reference documentation for the C#/.NET source in `Program.cs`.

## Requirements

- Doxygen 1.9 or later

## Generate the documentation

Run this from the repository root:

```sh
doxygen Doxyfile
```

The generated HTML site is written to `docs/doxygen/html/`. Open `docs/doxygen/html/index.html` in a browser. Doxygen also emits XML output in `docs/doxygen/xml/` for tooling that consumes XML documentation.

The API pages are generated from the XML documentation comments on `Program` and `Calculator` in `Program.cs`.
