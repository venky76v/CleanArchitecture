# Pull Request Review Task

Review this pull request as a senior .NET / ASP.NET Core engineer.

Use the repository guidance and engineering standards defined in:

- AGENTS.md

This is an advisory PR review.

Post the review back to GitHub:

- Use `gh pr comment` for the overall summary.
- Use `mcp__github_inline_comment__create_inline_comment` with `confirmed: true` for file-specific findings.
- Only post the review as GitHub comments. Do not leave the review only in the action output.

Do not:
- approve or reject the PR
- create commits
- modify files
- rewrite large sections of code unless there is a serious issue

Focus on meaningful engineering risks and actionable feedback.

---

# Review Objectives

Review the changed files in the PR and identify:

- correctness bugs
- security issues
- risky API changes
- input validation gaps
- null handling issues
- async / await misuse
- Entity Framework inefficiencies
- unbounded queries or pagination issues
- error handling problems
- risky logging practices
- secrets or credentials exposure
- CI/CD workflow risks
- weak or missing tests
- maintainability concerns

---

# Security Focus Areas

Pay particular attention to:

- authentication / authorization issues
- unsafe deserialization
- SQL injection risks
- unsafe file handling
- secrets in source code
- excessive GitHub Actions permissions
- unsafe pull_request_target usage
- risky third-party GitHub Actions

---

# Entity Framework Guidance

Look for:

- ToList() before filtering
- unbounded queries
- missing pagination
- missing AsNoTracking() where appropriate
- N+1 query risks
- synchronous database access
- inefficient Includes

---

# GitHub Actions Guidance

Look for:

- over-privileged workflows
- secrets exposed in logs
- missing validation steps
- risky workflow triggers
- unsafe shell usage

---

# Ignore

Do not comment on:

- formatting-only issues
- cosmetic refactoring
- personal naming preferences
- minor style opinions
- issues already enforced by compiler or formatter

Avoid noisy comments.

---

# Output Format

Start with a short overall summary.

Then provide findings using this structure:

## Finding

Severity: Critical | High | Medium | Low

File / Area:
- file name or workflow name

Issue:
- concise explanation of the issue

Why it matters:
- explain engineering or security impact

Suggested fix:
- practical recommendation

---

# Review Philosophy

Prefer:
- concise comments
- high-signal findings
- practical recommendations

Avoid:
- over-reviewing
- speculative comments
- unnecessary refactoring suggestions

If no meaningful issues are found, say:

"No major issues found. The PR looks reasonable based on the changed files."
