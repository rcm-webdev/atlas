# Atlas

## Project Structure

This repository is organized as a monorepo with the following structure:

- `packages/backend`: ASP.NET Core Web API.
  - Contains `Atlas.Backend.sln` solution file.
  - Source code is located in `src/Api`.
  
- `packages/frontend`: Vue.js Frontend application (Vite).

## Getting Started

### Backend

1. Navigate to `packages/backend`.
2. Run `dotnet restore`.
3. Run `dotnet run --project src/Api/asp-api.csproj`.

### Frontend

1. Navigate to `packages/frontend`.
2. Run `bun install` (or `npm install`).
3. Run `bun dev` (or `npm run dev`).

