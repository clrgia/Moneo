"use client";

import { Bar, BarChart, CartesianGrid, XAxis } from "recharts";
import { ChartTooltip, ChartTooltipContent } from "@/components/ui/chart";

import { ChartContainer, type ChartConfig } from "@/components/ui/chart";

const chartData = [
  { month: "January", Expenses: 186, Income: 80 },
  { month: "February", Expenses: 305, Income: 200 },
  { month: "March", Expenses: 237, Income: 120 },
  { month: "April", Expenses: 73, Income: 190 },
  { month: "May", Expenses: 209, Income: 130 },
  { month: "June", Expenses: 214, Income: 140 },
];

const chartConfig = {
  desktop: {
    label: "Expenses",
    color: "#F68067",
  },
  mobile: {
    label: "Income",
    color: "#377CFB",
  },
} satisfies ChartConfig;

export function Chart() {
  return (
    <ChartContainer config={chartConfig} className="min-h-[200px] w-full border rounded-lg p-6 ">
      <BarChart accessibilityLayer data={chartData}>
        <CartesianGrid vertical={false} />
        <XAxis
          dataKey="month"
          tickLine={false}
          tickMargin={10}
          axisLine={false}
          tickFormatter={(value) => value.slice(0, 3)}
        />
        <ChartTooltip content={<ChartTooltipContent />} />
        <Bar dataKey="Expenses" fill="var(--color-desktop)" radius={4} />
        <Bar dataKey="Income" fill="var(--color-mobile)" radius={4} />
      </BarChart>
    </ChartContainer>
  );
}
