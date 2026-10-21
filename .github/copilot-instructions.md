# GitHub Copilot Instructions for Defensive Moats (Continued) Mod

## Mod Overview and Purpose
**Defensive Moats (Continued)** is a mod for RimWorld that allows players to construct moats that serve as formidable barriers to incoming threats. Originally developed by Denni, this mod has been updated to support the newest version of RimWorld. Its key purpose is to enhance defensive strategies by adding unique terrain obstacles.

## Key Features and Systems
- **Moats:** Players can dig moats around their settlements to hinder enemy movement and provide strategic advantages during raids.
- **Bridges:** Wooden bridges can be constructed to navigate over moats while maintaining the defensive perimeter.
- **Multilingual Support:** The mod includes support for multiple languages, including Japanese, thanks to community contributions.
- **Compatibility:** Designed to be compatible with RimWorld version 1.1 and later.

## Coding Patterns and Conventions
- **C# Naming Conventions:** Classes and methods follow PascalCase, such as `Building_MoatBridge` and `SpawnSetup`.
- **XML Structure:** Organized into logical segments with `ThingDef` elements defining new building objects and properties.
- **File Organization:** All source files are stored under `Source\DefensiveMoats`, with additional data and definition files located in the `Defs` folder.

## XML Integration
- **ThingDefs:** Used to define moats and bridges in the game. Located in `Defs\ThingDefs_Buildings`.
  - Example: 
    - `Buildings_Bridges.xml` for bridge definitions.
    - `Buildings_Moats.xml` for moat definitions.
- **Localization Support:** Utilized through separate XML files for ease of translation, such as `ThingDef\Buildings_Bridges.xml` for language templates.

## Harmony Patching
While there are no current Harmony patches in this mod, should you need to override any base game functions, consider using Harmony:
- **Use Cases:** If you need to hook into RimWorld’s methods to make complex changes.
- **Basics:** Define a prefix or postfix method using `HarmonyPatch` attribute.

## Suggestions for Copilot
1. **Code Completion:** Recommend function signatures for class methods like `DeSpawn` and `SpawnSetup` in `Building_MoatBridge`.
2. **XML Management:** Help structure new `ThingDef` entries accurately according to existing templates.
3. **Debugging Extensions:** Assist with adding logging hooks or error handling during the addition of new features.
4. **Localization Addition:** Propose consistent language strings for new translations following provided templates.
5. **Project Organization:** Suggest best practices for directory management to keep the mod’s codebase organized for future updates.

This guide aims to assist developers who wish to contribute to the development of the Defensive Moats (Continued) mod with clear guidelines on coding and modification practices.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

