﻿/* Copyright (C) 2009-2012 Fairmat SRL (info@fairmat.com, http://www.fairmat.com/)
 * Author(s): Matteo Tesser (matteo.tesser@fairmat.com)
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System.Reflection;
using Mono.Addins;

// The following lines tell that the assembly is an addin
[assembly: Addin("Hull-White two factors model", "1.0.9", Category = "Stochastic Process")]
[assembly: AddinDependency("Fairmat", "1.0")]
[assembly: AddinAuthor("Fairmat SRL")]
[assembly: AddinDescription("A no-arbitrage model which is the industry standard " +
                            "for modeling the future interest rate dynamic which " +
                            "uses two factors in order to handle better situations " +
                            "like pricing a derivative whose payoff depends on " +
                            "rates at different maturities.")]
[assembly: AssemblyTrademark("Fairmat")]
[assembly: AssemblyCulture("")]
