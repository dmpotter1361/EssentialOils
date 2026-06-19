# Essential Oils — notes for Claude Code

C# / .NET 10 WinForms essential-oil reference & blend calculator (ported from VB.NET).
Windows-only. Repo `dmpotter1361/EssentialOils` (shipped v1.0.0 MSI, unsigned).

## Run / build

```powershell
dotnet run                 # launch the app
dotnet build -c Release    # release build
./build.ps1                # packaging / release (MSI) script
```

No tests. Plain `dotnet` is enough.

## Layout

- **`oils.json`** — **single source of truth** for all oil data. To change oil
  info, edit this file — no code change required. Copied next to the exe at build.
- **`OilCatalog.cs`** — loads `oils.json`; exposes lookups.
- **`Recipe.cs`** — blend/recipe model + calculations.
- **`MainForm.cs`** — main window.
- **`ResearchForm.cs`** — per-oil research/detail popup.

## Conventions

- Keep `oils.json` as the source of truth — don't hard-code oil text in C#.
- Forms hand-written in code; **UI must survive font/display-scaling changes**
  (TableLayoutPanel/FlowLayoutPanel + AutoSize + font fallback).
