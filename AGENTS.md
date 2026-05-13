# Repository AI Guidance

This repository is used to demonstrate:

- .NET / ASP.NET Core development
- GitHub Actions validation builds
- CodeQL security scanning
- AI-assisted pull request review using Claude

---

# Repository Architecture

This repository follows Clean Architecture principles.

Primary layers include:

- Web/API layer
- UseCases/Application layer
- Core/Domain layer
- Infrastructure/Data layer
- Test projects

Dependencies should flow inward.

The Core layer must not depend on Infrastructure.

---

# Technology Stack

- .NET
- ASP.NET Core
- C#
- Entity Framework Core
- SQL Server / LocalDB
- GitHub Actions
- CodeQL

---

# AI Agent Expectations

AI agents operating in this repository should:

- prefer read-only analysis unless explicitly asked to modify code
- avoid destructive operations
- avoid automatic commits unless explicitly requested
- explain assumptions clearly
- provide practical and actionable recommendations
- avoid noisy comments

---

# Pull Request Review Philosophy

PR reviews should focus on:

1. security risks
2. correctness bugs
3. API behavior changes
4. validation gaps
5. database access inefficiencies
6. CI/CD risks
7. missing tests
8. maintainability concerns

Avoid over-focusing on formatting or cosmetic issues.

---

# .NET Guidance

When reviewing .NET code, pay attention to:

- async / await correctness
- null reference risks
- exception handling
- cancellation token usage where appropriate
- logging of sensitive data
- dependency injection misuse
- configuration safety
- API contract stability

---

# Entity Framework Guidance

Look for:

- unbounded queries
- missing pagination
- ToList() before filtering
- N+1 query issues
- unnecessary tracking queries
- inefficient Includes
- synchronous database calls

Prefer efficient and safe query patterns.

---

# API Guidance

API endpoints should:

- validate input
- return appropriate status codes
- avoid leaking internal details
- avoid breaking contracts unexpectedly
- use pagination where appropriate

---

# GitHub Actions Guidance

GitHub workflows should:

- use least privilege permissions
- avoid exposing secrets
- validate builds and tests
- avoid unsafe workflow triggers
- avoid unnecessary third-party actions

---

# Testing Expectations

Changes should normally include:

- unit tests for business logic changes
- integration tests for API behavior changes where appropriate
- meaningful assertions

Avoid superficial tests that provide little validation value.

---

# Expected Review Style

Reviews should:

- be concise
- focus on meaningful issues
- provide practical fixes
- use severity levels
- avoid unnecessary noise

If no major issue exists, clearly say so.