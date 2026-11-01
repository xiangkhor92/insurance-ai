# Insurance AI: quick guide

**What it does:** Insurance AI reads your client quotations and policies from Google Drive. It turns each one into a one-minute summary in English or Malay. It also reminds you 3 days before a quotation expires, a premium is due or a policy needs renewal.

**Open the app:** https://claude.ai/artifact/MxsF59325xje22TfX2yjXX
Tip: on your phone, open the link and choose *Add to Home Screen*.

## Every day, automatically (8:00 am)
1. The app checks Google Drive › **2. Policy Review** › every client subfolder.
2. Each **new** PDF or photo gets summarised: protection coverage, sum insured, premium (and how it rises over time), waiting period, key exclusions, free-look and grace period.
3. If any date is **0–3 days away**, you get:
   - a phone or desktop notification;
   - a **Gmail draft to yourself** (look in *Drafts*) with a ready-to-copy client message in English and Malay. Nothing is ever sent to a client.

> The 8:00 am check runs while the Claude desktop app is open on your computer. If the app is closed at 8:00 am, the check runs the next time you open it.

## Adding a new client
Create a subfolder in **2. Policy Review** (for example `14. Lim Ah Kow`) and drop the PDF in. The next morning it appears in the app. To see it sooner, open the Claude app › **Scheduled** › *Insurance AI – daily policy check* › **Run now**.

## Using the app
- **EN / BM** button (top right): switches the whole app between English and Malay.
- **Reminders**: what's due in the next 3 days, with a **Copy message** button so you can paste it into WhatsApp.
- **Clients**: tap a name to see the full summary.
  - **Verify** chip: the summary needs a human check, for example a placeholder name like "aaa", a blurry scan or numbers that don't match.
  - **Dates missing** chip: the PDF didn't print that date. Quotations usually don't.
- **Add a missing date:** open the client, scroll to *Reminder dates*, pick the date and tap **Add date**. Monthly premiums roll forward to the next due date by themselves.

## Safety rules built in
- Missing information shows as **"Not stated"**. Nothing is guessed.
- Your Drive files are only read. They are never moved, renamed, edited or deleted.
- Emails are only saved as drafts to you, never sent.
- Dates you type in are never overwritten by the daily check.
