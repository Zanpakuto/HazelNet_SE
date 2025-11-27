Here is the **updated UI Spec Sheet (.md)** using your colors **#5C899D (main)** and **#FFFCEF (accent background)** — and below it, I explain the **correct Avalonia solution (NOT hardcoding values)**.

---

# Kards.Net – UI Specification (Updated)

## 1. Typography

* **Font Family:** `-apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif`
* **Title:** 22–24px, 700
* **Header:** 18px, 600
* **Body:** 14–15px, 400
* **Small Text:** 12px, 600

### Text Colors

* Primary: `#1E293B`
* Secondary: `#64748B`
* Muted: `#94A3B8`

---

## 2. Color Palette

### Main Brand Colors

* **Primary:** `#5C899D`
* **Primary Dark:** `#4A6F80`
* **Accent Background:** `#FFFCEF`

### Surfaces & Background

* App Background: `#FFFCEF`
* Card Background: `#FFFFFF`
* Input Background: `#F1F5F9`

### Borders

* Light Border: `#e2e8f0`

---

## 3. Layout

### Sidebar

* Width: 260–280px
* Background: white
* Border-right: `1px solid #e2e8f0`
* Active Nav:

    * Background: `#E7F1F5` (tint of primary)
    * Text: `#1E293B`

### Header

* Background: white
* Border-bottom: `1px solid #e2e8f0`
* Layout: Flex (space-between)

### Content Area

* Padding: 24px
* Deck cards in grid (responsive)

---

## 4. Card Design

### Card Container

* Background: white
* Radius: 12px
* Padding: 24px
* Shadow: `0 1px 4px rgba(0,0,0,0.1)`
* Hover:

    * `translateY(-3px)`
    * stronger shadow

### Card Top Accent (4px)

* **Uses brand gradient:**

  ```
  linear-gradient(135deg, #5C899D 0%, #4A6F80 100%)
  ```

### Card Content

* Title: 18px bold
* Subtitle: secondary text
* Badge:

    * Background: `#E7F1F5`
    * Text: `#5C899D`
    * Radius: 12px
    * Padding: 6px 12px

---

## 5. Buttons

### General Button

* Radius: 6px
* Padding: 10px 16px
* Weight: 600
* Transition: 0.2s ease

### Primary Action (Study)

* Background: `#5C899D`
* Hover: `#4A6F80`
* Text: white

### Create Button

* Gradient:

  ```
  linear-gradient(135deg, #5C899D 0%, #4A6F80 100%)
  ```

---

## 6. Inputs

### Search Box

* Background: `#F1F5F9`
* Border: `1px solid #e2e8f0`
* Radius: 8px
* Placeholder: `#94a3b8`

---

## 7. Grid Layout

### Deck Grid

```css
display: grid;
grid-template-columns: repeat(auto-fill, minmax(320px, 1fr));
gap: 20px;
```

---

## 8. Effects

### Animations

* Card hover: 0.3s ease
* Button hover: 0.2s
* Button click: scale(0.95)

### Optional Glass Overlay

```
backdrop-filter: blur(10px);
background: rgba(255, 255, 255, 0.6);
border-radius: 20px;
```

---
