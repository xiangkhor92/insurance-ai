# Insurance AI

Summarises client insurance quotations and policies from Google Drive into a one-minute read in English or Malay, and reminds you 3 days before a quotation expires, a premium is due or a policy renews.

- **Open the app:** https://claude.ai/artifact/MxsF59325xje22TfX2yjXX (signed in to Claude)
- **How to use it:** [Insurance-AI-Guide.md](Insurance-AI-Guide.md)

## What's in this repository

| File | What it is |
|---|---|
| `insurance-ai.html` | Source of the app page. It runs inside Claude, which stores the summaries, so opening this file on its own shows an empty app. |
| `launcher/InsuranceAI.exe` | Windows launcher that opens the app in your browser. Source: `launcher/InsuranceAI.cs` |
| `Insurance-AI-Guide.md` | Plain-English guide |

The daily 8:00 am Drive check is a scheduled task in the Claude desktop app (*Insurance AI – daily policy check*), not part of this repository.

Client documents are never stored here (see `.gitignore`).
