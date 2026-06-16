# Essential Oil Mixer

<p align="center">
  <img src="appicon-preview.png" width="96" alt="Essential Oil Mixer icon"><br>
  <a href="https://github.com/dmpotter1361/EssentialOils/releases/latest"><img src="https://img.shields.io/github/v/release/dmpotter1361/EssentialOils?label=download&sort=semver&cacheSeconds=300" alt="Latest release"></a>
</p>

A small Windows app for blending essential oils. Pick your top, middle, and base
notes, a carrier oil, and a bottle size, and it works out a properly diluted
recipe — how many millilitres of each oil to use — using the classic 30/50/20
note ratio at a 3% dilution. It also shows the scent profile of your blend and
includes a built-in reference on every oil, read aloud if you like.

> Personal project. For hobby blending — not medical advice. Essential oils are
> potent; always dilute and patch-test, and check guidance before use on skin.

### ⬇ Download

**[Get the latest version](https://github.com/dmpotter1361/EssentialOils/releases/latest)** —
download `EssentialOils-x.y.z-x64.msi` from the latest release and run it. It installs
like any normal program (shows in **Add/Remove Programs**, and a newer version replaces
the old one automatically). No setup or accounts. (It's a personal build and not
code-signed, so Windows SmartScreen may warn — choose **More info → Run anyway**.)

## Features

- **Recipe builder** — select oils across the **Top / Middle / Base** note columns,
  a **carrier oil**, and a **bottle size** (15 ml → 960 ml), then click **Create Recipe**
  for a per-oil millilitre breakdown.
- **Smart ratios** — uses the 30/50/20 top/middle/base split at a 3% essential-oil
  dilution, and automatically redistributes a tier's share across the others when you
  leave that tier empty.
- **Scent profile** — highlights the **fragrance families** (Citrus, Floral, Herbal,
  Spicy, Woody) and **effects** (Energizing, Relaxing, Cleansing, Grounding) your blend
  covers. Click any family or effect to list the oils in it.
- **Oil reference** — flip on **Research** mode for any column and click an oil to read
  a full description, with **text-to-speech** (selectable voice) and **print**.
- **Copy / Print / Save** — copy the recipe to the clipboard, print it, or save it as a
  text file you can keep with your notes.

## Requirements

- **Windows 10/11 (x64).** The .NET runtime is bundled in the installer.
- Text-to-speech uses the Windows system voices (e.g. *Microsoft David / Zira*).

## Build from source

Prerequisites: [.NET 10 SDK](https://dotnet.microsoft.com/) and
WiX v5 (`dotnet tool install --global wix --version 5.0.2`).

```powershell
# Run the app
dotnet run --project EssentialOils.csproj

# Build the MSI installer (publishes self-contained, then builds the MSI)
pwsh ./build.ps1 -Version 1.0.0
```

## How it works

Every oil — its note column(s), fragrance families, effects, and reference description —
lives in a single data file, [`oils.json`](oils.json). The app loads it once at startup,
so adding or editing an oil is just a JSON edit; no code changes. The dilution maths and
scent-profile aggregation are pure, UI-free logic in [`Recipe.cs`](Recipe.cs), and the
two windows ([`MainForm.cs`](MainForm.cs) and [`ResearchForm.cs`](ResearchForm.cs)) just
present it.

## Continuing development with Claude Code

This project was cleaned up and converted with AI assistance and is set up so you can
keep going the same way. To pick up where it left off on your own machine:

1. **Get the code onto your PC**

   ```bash
   git clone https://github.com/dmpotter1361/EssentialOils.git
   cd EssentialOils
   ```

2. **Install [Claude Code](https://claude.com/claude-code)** (Anthropic's coding CLI)
   and start it in the project folder:

   ```bash
   npm install -g @anthropic-ai/claude-code
   claude
   ```

   (You can also use the Claude Code extension for VS Code / JetBrains, or
   [claude.ai/code](https://claude.ai/code).)

3. **Point Claude at the project and ask for what you want.** A good first prompt:

   > Read the README, `oils.json`, and `Recipe.cs`, then run the app so you understand
   > it. I'd like to add &lt;your feature&gt;.

### Helpful map for a new contributor (human or AI)

- **`oils.json`** — the single source of truth: every oil and carrier with its
  families, effects, and description. Edit this to add or change oils.
- **`OilCatalog.cs`** — strongly-typed model + loader for `oils.json`.
- **`Recipe.cs`** — pure dilution maths (the 30/50/20 split and redistribution) and
  scent-profile aggregation. No UI — the easiest place to add a test.
- **`MainForm.cs`** — the main window: list boxes, the recipe builder, profile highlights,
  copy/print/save.
- **`ResearchForm.cs`** — the per-oil description popup with print and text-to-speech.
- **`installer/Package.wxs` + `build.ps1`** — the WiX MSI installer.

## Acknowledgments

Essential Oil Mixer was **originally written by the author in Visual Basic**. It was later
**cleaned up and rewritten in C# / .NET 10 collaboratively with Claude** (Anthropic's AI) —
consolidating the oil data into a single source of truth, untangling the duplicated logic,
fixing a few bugs, and adding the installer and this README. The direction, decisions, and
real-world testing are human; a lot of the cleanup and conversion was AI-assisted — and
we're happy to say so. 🤖🤝

## License

[GPL-3.0](LICENSE)
