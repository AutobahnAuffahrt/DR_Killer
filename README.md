# DR_Killer

Ein kleines WinForms-Tool (C#/.NET Framework 4.8), das in einem Verzeichnisbaum typische Visual-Studio-Build-Artefakte und Datenbank-/Cache-Dateien aufspürt und bei Bedarf löscht. Ideal, um alte Projekte aufzuräumen und Speicherplatz zurückzugewinnen.

<!-- Optionaler Build-Status-Badge nach dem Push anpassen: -->
<!-- ![Build](https://github.com/<user>/<repo>/actions/workflows/build.yml/badge.svg) -->

## Kurzüberblick

- Sucht rekursiv nach Verzeichnissen: `Debug`, `Release`, `ipch`
- Sucht nach Dateien: `*.ncb`, `*.sdf` (alte VS-Datenbanken/Caches)
- Zeigt Liste und geschätzte Gesamtgröße an
- Löscht auf Knopfdruck gefundene Ordner/Dateien

## Anforderungen

- Windows
- .NET Framework 4.8 (für das Kompilieren und Ausführen)
- Visual Studio (empfohlen) oder Build-Tools mit MSBuild

## Build & Run

### Visual Studio

1. Solution `DR_Killer.sln` öffnen.
2. Konfiguration „Release | x86“ auswählen.
3. Build ausführen und `DR_Killer.exe` aus `DR_Killer/bin/Release` starten.

### MSBuild (lokal)

- Stelle sicher, dass MSBuild (z. B. über Visual Studio Build Tools) im `PATH` ist.
- Rebuild (PowerShell):

```powershell
msbuild .\DR_Killer.sln /t:Rebuild /p:Configuration=Release /p:Platform=x86
```

## Verwendung

1. Starten der App.
2. Mit „…“ ein Ausgangsverzeichnis wählen.
3. „Suchen“ zeigt gefundene Ordner/Dateien und die Größe an.
4. „löschen“ entfernt die Einträge rekursiv. Fehler werden im Ausgabefeld angezeigt.

Hinweis: Es werden ausschließlich die obigen Ordner/Dateien gesucht/gelöscht. Andere Projektdateien bleiben unberührt.

## CI/CD

Ein GitHub Actions Workflow (`.github/workflows/build.yml`) baut die Solution automatisch auf `windows-latest` und lädt das Release-Build als Artefakt hoch.

## Roadmap / Ideen

- Optionale Muster erweitern (z. B. `*.ipch`, `.vs`, `*.opensdf`).
- „Trockenlauf“-Modus und Export als Logdatei.
- Ausgewählte Pfade ausschließen.

## Lizenz

Dieses Repository enthält eine MIT-Lizenzvorlage im `LICENSE`-File. Bitte Namen und Jahr anpassen.

---

Dieses Projekt entstand ursprünglich als Helferlein zum Aufräumen alter VS-Projekte und wurde hier als kleines Showcase aufbereitet.
